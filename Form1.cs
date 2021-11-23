using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Low_Energy_Optimizer
{
    public partial class Form1 : Form
    {
        private LinkedListNode<Process> runningProcess = null;
        private LinkedList<Process> processQueue = new LinkedList<Process>();
        private Process[] savedQueue = null;

        private double run_speed = 1.0;
        private int base_sleep_time = 1000;
        private double elapsed_time = 0;
        private int work_unit = 1000;
        private double cpu_speed = 1.0;
        private double psu_efficiency = 0.8;

        private double ambient_temp = 24.0;
        private double rack_temp = 24.0;
        private double outdoor_temp = 22.0;

        private double server_h = 2;
        private double server_w = 0.6;
        private double server_l = 1.2;
        private double server_mass = 1363;
        private double server_sqm = 3.71612;
        private double server_sa;
        private double room_h = 4;
        private double wall_conductivity = 2.25;
        private double wall_thickness = 0.1016;

        private double nodePower;
        private double totalPower;
        private double rackPower;
        private double hvacPower;

        private bool hvacSet = false;
        private bool infinite_run = false;
        private bool server_on = false;
        Stopwatch hvac_timer = new Stopwatch();
        private double hvac_runtime = 0;

        public double HvacPower {
            get => hvacPower;
            set {
                hvacPower = value;
            } 
        }

        public Form1()
        {
            InitializeComponent();
            this.Text = "Low Energy Optimizer";
            processQueueGenerator.WorkerSupportsCancellation = false;
            processQueueGenerator.WorkerReportsProgress = true;
            runner.WorkerReportsProgress = true;
            runner.WorkerSupportsCancellation = true;
            //speedLabel.Text = String.Format("{0:f1}x", speedSelector.Value / 100);
            elapsedTimeLabel.Text = String.Format("Elapsed Time: {0:f2}s",elapsed_time);
            //cpuSpeedLabel.Text = String.Format("{0}%",cpuSpeedSelector.Value);
            cpuSpeedSelector.Value = 100;
            simSpeedSelector.Value = 100;
            psuSelector.Value = 80;
            nodeIdlePower.Value = 100;
            nodePeakPower.Value = 300;
            HvacPower = 0;
            server_sa = (2 * server_l * server_w) + (2 * server_l * server_h) + (server_h * server_w);
            processBoundRadio.Enabled = false;
            infiniteRadio.Checked = true;
            outdoorTempLabel.Text = String.Format("{0:f1}°C", outdoor_temp);
            temperatureControl.RunWorkerAsync();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void loadCSVToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "") {
                if (!processQueueGenerator.IsBusy) {
                    statusLabel.Text = "Generating Process Queue...";
                    processQueueGenerator.RunWorkerAsync(openFileDialog.FileName);
                }
            }
            
        }

        private void processQueueGenerator_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            int counter = 0;
            int row_count = 0;
            foreach (string row in System.IO.File.ReadLines(e.Argument.ToString())) {
                row_count++;
            }
            foreach (string row in System.IO.File.ReadLines(e.Argument.ToString())) {
                if (counter > 0) {
                    string[] values = row.Split('\u002C');
                    Process process = new Process(Int32.Parse(values[0]), Double.Parse(values[1]), Double.Parse(values[2]));
                    if (processQueue.Count == 0) {
                        processQueue.AddLast(process);
                    } else {
                        LinkedListNode<Process> current = processQueue.First;
                   
                        while (current != null) {
                            if (current.Value.Priority >= process.Priority)
                                break;
                            current = current.Next;
                        }
                        if (current == null) {
                            processQueue.AddLast(process);
                        } else {
                            processQueue.AddBefore(current, process);
                        }
                    }
                }
                counter++;
                worker.ReportProgress(counter * 100 / row_count);
            }
            worker.ReportProgress(100);
        }

        private void processQueueGenerator_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            statusProgress.Value = e.ProgressPercentage;
        }

        private void processQueueGenerator_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            generateProcessView();
            statusProgress.Value = 0;
            statusLabel.Text = "Idle";
            processBoundRadio.Enabled = true;
            processBoundRadio.Checked = true;
            infiniteRadio.Checked = false;
            saveQueue();
        }

        private void runButton_Click(object sender, EventArgs e) {
            if (!server_on) {
                MessageBox.Show("Server has been shut down.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (runner.IsBusy) {
                statusProgress.MarqueeAnimationSpeed = 0;
                statusProgress.Style = ProgressBarStyle.Continuous;
                statusProgress.Value = 100;
                statusLabel.Text = "Cancelling Run...";
                runner.CancelAsync();
            } else {
                //if (processQueue.First == null) {
                //    MessageBox.Show("Process Queue is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                runButton.Text = "Stop";
                statusProgress.Style = ProgressBarStyle.Marquee;
                statusProgress.MarqueeAnimationSpeed = 25;
                runner.RunWorkerAsync();
                computePower(this, e);

            }

        }

        private void runner_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            int rowIndex = 0;
            if (runningProcess == null)
                runningProcess = processQueue.First;
            bool Finished = true;

            if (infinite_run) {
                statusLabel.Text = "Running Full Load...";
                while (true) {
                    int sleep_time = (int)(base_sleep_time / run_speed);
                    elapsed_time += base_sleep_time / 1000;
                    worker.ReportProgress(0);
                    for (int i = 0; i < sleep_time; i += 10) {
                        System.Threading.Thread.Sleep(10);
                    }
                    if (worker.CancellationPending) {
                        e.Cancel = true;
                        break;
                    }
                }
            } else {
                while (true) {
                    if (!runningProcess.Value.Done) {
                        Finished = false;
                        statusLabel.Text = String.Format("Running Process {0}...", runningProcess.Value.Id);
                        DataGridViewRow row = processView.Rows
                            .Cast<DataGridViewRow>()
                            .Where(r => r.Cells["PID"].Value.ToString().Equals(runningProcess.Value.Id.ToString()))
                            .First();
                        rowIndex = row.Index;
                        processView.Rows[rowIndex].Selected = true;
                        for (int p = 0; p <= 2 - runningProcess.Value.Priority; p++) {
                            int sleep_time = (int)(base_sleep_time / run_speed);
                            if (runningProcess.Value.Remaining < 1000) {
                                sleep_time = (int)(sleep_time * (runningProcess.Value.Remaining / 1000));
                                elapsed_time += (base_sleep_time * (runningProcess.Value.Remaining / 1000)) / 1000;
                                runningProcess.Value.Remaining = 0;
                                runningProcess.Value.Done = true;
                            } else {
                                runningProcess.Value.Remaining = runningProcess.Value.Remaining - (work_unit * cpu_speed);
                                elapsed_time += base_sleep_time / 1000;
                            }
                            worker.ReportProgress(0);
                            for (int i = 0; i < sleep_time; i += 10) {
                                System.Threading.Thread.Sleep(10);
                            }
                            processView.Rows[rowIndex].Cells["Done"].Value = runningProcess.Value.Done.ToString();
                            processView.Rows[rowIndex].Cells["Remaining Work"].Value = runningProcess.Value.Remaining.ToString();
                            if (runningProcess.Value.Done) {
                                processView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                            }
                        }

                    }
                    if (runningProcess == processQueue.Last) {
                        if (Finished) break;
                        runningProcess = processQueue.First;
                        Finished = true;
                    } else {
                        runningProcess = runningProcess.Next;
                    }
                    if (worker.CancellationPending) {
                        e.Cancel = true;
                        processView.Rows[rowIndex].Selected = false;
                        processView.Rows[rowIndex + 1].Selected = true;
                        break;
                    }
                    processView.Rows[rowIndex].Selected = false;
                }
            }
        }

        private void runner_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            elapsedTimeLabel.Text = String.Format("Elapsed Time: {0:f2}s", elapsed_time);
        }

        private void runner_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            statusProgress.Value = 0;
            if (e.Cancelled) {
                statusLabel.Text = "Run Cancelled.";
            } else {
                statusLabel.Text = "Run Complete.";
                runningProcess = null;
            }
            runButton.Text = "Run";
            statusProgress.Style = ProgressBarStyle.Continuous;
            statusProgress.MarqueeAnimationSpeed = 0;
            computePower(sender, e);
        }

        private void saveQueue() {
            savedQueue = new Process[processQueue.Count];
            int i = 0;
            foreach (Process process in processQueue) {
                savedQueue[i++] = new Process(process);
            }
        }

        private void loadQueue() {
            processQueue = new LinkedList<Process>(savedQueue);
            generateProcessView();
        }

        private void generateProcessView() {
            if (processQueue == null) return;
            DataTable dt;
            dt = new DataTable();
            dt.Columns.Add("PID");
            dt.Columns.Add("Priority");
            dt.Columns.Add("Remaining Work");
            //dt.Columns.Add("Deadline");
            dt.Columns.Add("Done");
            foreach (Process process in processQueue) {
                DataRow dr = dt.NewRow();
                dr["PID"] = process.Id;
                dr["Priority"] = process.Priority;
                dr["Remaining Work"] = process.Remaining;
                //dr["Deadline"] = process.Deadline;
                dr["Done"] = process.Done.ToString();
                dt.Rows.Add(dr);
            }
            //statusProgress.Value = 0;
            //statusLabel.Text = "Idle";
            processView.DataSource = null;
            processView.Refresh();
            processView.DataSource = dt;
            processView.Refresh();
            processView.Rows[0].Selected = false;
        }

        private void resetButton_Click(object sender, EventArgs e) {
            elapsed_time = 0;
            elapsedTimeLabel.Text = String.Format("Elapsed Time: {0:f2}s", elapsed_time);
            if (savedQueue != null) {
                loadQueue();
            }
            runningProcess = null;
            ambient_temp = 24.0;
            rack_temp = 24.0;
            hvac_runtime = 0;
            computePower(this, e);
            rackTempLabel.Text = String.Format("{0:f1}°C", rack_temp);
            ambTempLabel.Text = String.Format("{0:f1}°C", ambient_temp);
            hvacRuntimeLabel.Text = String.Format("{0:2f}s", hvac_runtime);
        }

        private void cpuSpeedSelector_ValueChanged(object sender, EventArgs e) {
            int value = cpuSpeedSelector.Value;
            if (value % cpuSpeedSelector.SmallChange != 0) {
                value = (int)(Math.Round((Double)value/cpuSpeedSelector.SmallChange) * cpuSpeedSelector.SmallChange);
                Debug.WriteLine(String.Format("CPU_SPEED_SELECTOR: {0}", value));
                cpuSpeedSelector.Value = value;
            }
            cpu_speed = (Double)value / 100.0;
            cpuSpeedLabel.Text = cpuSpeedLabel.Text = String.Format("{0}%", cpuSpeedSelector.Value);
            computePower(this, e);
        }

        private void simSpeedSelector_ValueChanged(object sender, EventArgs e) {
            int value = simSpeedSelector.Value;
            if (value % simSpeedSelector.SmallChange != 0) {
                value = (int)(Math.Round((Double)value / simSpeedSelector.SmallChange) * simSpeedSelector.SmallChange);
                simSpeedSelector.Value = value;
            }
            run_speed = (Double)value / 100.0;
            simSpeedLabel.Text = String.Format("{0:f1}x", simSpeedSelector.Value / 100.0);
        }

        private void psuSelector_ValueChanged(object sender, EventArgs e) {
            int value = psuSelector.Value;
            if (value % psuSelector.SmallChange != 0) {
                value = (int)(Math.Round((Double)value / psuSelector.SmallChange) * psuSelector.SmallChange);
                psuSelector.Value = value;
            }
            psu_efficiency = (Double)value / 100.0;
            psuLabel.Text = String.Format("{0}%", psuSelector.Value);
            computePower(this, e);
        }

        private void computePower(object sender, EventArgs e) {
            if (!server_on) {
                nodePower = 0;
            } else {
                if (runner.IsBusy) {
                    nodePower = (((Double)nodePeakPower.Value - (Double)nodeIdlePower.Value) * cpu_speed) + (Double)nodeIdlePower.Value;
                } else {
                    nodePower = (Double)nodeIdlePower.Value;
                }
            }
            rackPower = nodePower * (Double)serversPerRack.Value / psu_efficiency;
            totalPower = rackPower - HvacPower;
            powerDrawLabel.Text = String.Format("{0:f0}W", nodePower);
            rackPowerLabel.Text = String.Format("{0:f0}W", rackPower);
            totalPowerLabel.Text = String.Format("{0:f0}W", totalPower);
            hvacPowerLabel.Text = String.Format("{0:f0}W", -HvacPower);
        }

        private void temperatureControl_DoWork(object sender, DoWorkEventArgs e) {
            BackgroundWorker worker = sender as BackgroundWorker;
            double steel_c = 460.548;
            double air_c = 1006;
            double air_density = 1.225;
            worker.ReportProgress(0);
            double room_side = Math.Sqrt(server_sqm);
            while (true) {
                double room_vol = server_sqm * room_h;
                double air_mass = air_density * room_vol - (server_h * server_l * server_w);
                double wall_heat_loss = 0;
                wall_heat_loss = wall_conductivity * (4 * room_side * room_h + server_sqm) * ((outdoor_temp - ambient_temp) / wall_thickness);
                Debug.WriteLine(String.Format("wall_loss = {0}", wall_heat_loss));
                double qA = (air_mass * air_c * (rack_temp - ambient_temp)) + HvacPower + wall_heat_loss + rackPower;
                Debug.WriteLine(String.Format("qA = {0}", qA));
                ambient_temp += qA / (air_mass * air_c);
                //Debug.WriteLine(String.Format("amb_t = {0}", ambient_temp));
                //double qR = qA + (steel_c * server_mass * (ambient_temp - rack_temp));
                double qR = (steel_c * server_mass * (ambient_temp - rack_temp)) + HvacPower + wall_heat_loss + rackPower;
                Debug.WriteLine(String.Format("qR = {0}", qR));
                rack_temp += qR / (steel_c * server_mass);
                //Debug.WriteLine(String.Format("rack_t = {0}", rack_temp));

                if (ambient_temp > 30.0) {
                    hvacSet = true;
                } else if (ambient_temp <= 24.0) {
                    hvacSet = false;
                }
                if (hvacSet) {
                    
                    HvacPower = -8000;
                    //Debug.WriteLine(String.Format("hvac_p = {0}", HvacPower));
                } else {
                    HvacPower = 0;
                }
                worker.ReportProgress(5);
                if (hvacSet) {
                    hvac_runtime += base_sleep_time;
                }
                System.Threading.Thread.Sleep((int)(base_sleep_time / run_speed));
                Debug.WriteLine("\n");
            }
        }

        private void temperatureControl_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            rackTempLabel.Text = (String.Format("{0:f1}°C", rack_temp));
            ambTempLabel.Text = (String.Format("{0:f1}°C", ambient_temp));
            if (ambient_temp <= 26.0) {
                ambTempLabel.ForeColor = Color.Green;
                rackTempLabel.ForeColor = Color.Green;
            } else if (ambient_temp < 30.0) {
                ambTempLabel.ForeColor = Color.Orange;
                rackTempLabel.ForeColor = Color.Orange;
            } else {
                ambTempLabel.ForeColor = Color.Red;
                rackTempLabel.ForeColor = Color.Red;
            }
            hvacRuntimeLabel.Text = String.Format("{0:f2}s", hvac_runtime / 1000);
            computePower(this, e);
        }

        private void temperatureControl_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            Debug.WriteLine("Temperature control ended!!!");
        }

        private void processBoundRadio_CheckedChanged(object sender, EventArgs e) {
            if (processBoundRadio.Checked) {
                infinite_run = false;
            } else {
                infinite_run = true; 
            }
        }

        private void startServer_Click(object sender, EventArgs e) {
            if (!server_on) {
                server_on = true;
                startServer.Text = "Shutdown Server";
            } else {
                if (runner.IsBusy) runner.CancelAsync();
                server_on = false;
                startServer.Text = "Start Server";
            }
            computePower(this, e);
        }
    }
}
