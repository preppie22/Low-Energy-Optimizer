using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Energy_Optimizer {
    public class Process {
        private static int _counter = 0;
        private int _priority;
        private readonly int _id;
        private double _remaining;
        private double _deadline;
        private bool _done;

        public int Priority { 
            get => _priority;
            set {
                if (value >= 0 && value <= 2)
                    _priority = value;
                else
                    _priority = 0;
                    Debug.WriteLine("Invalid Priority. Setting to 0.");
            }
        }
        public double Deadline { 
            get => _deadline;
            set {
                if (value > 0)
                    _deadline = value;
                else
                    _deadline = 0;
            }
        }
        public bool Done { get => _done; set => _done = value; }
        public double Remaining { 
            get => _remaining;
            set {
                if (value > 0)
                    _remaining = value;
                else
                    _remaining = 0;
            }
        }
        public int Id => _id;

        public Process(int priority = 0, double remaining = 0, double deadline = 0) {
            _counter++;
            _id = _counter;
            Priority = priority;
            Remaining = remaining;
            Deadline = deadline;
            Done = false;
        }

        public Process(Process process) {
            _id = process._id;
            Priority = process._priority;
            Remaining = process._remaining;
            Deadline = process._deadline;
            Done = process._done;
        }
        ~Process() {
            _counter--;
        }
    }
}