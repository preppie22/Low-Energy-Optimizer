# Low Energy Optimizer

This is part of a class project for CS 789: Real-Time and Embedded Systems. This tool estimates power draw in a standard server rack while taking into account
heat transfer and cooling systems. Currently, there are a ton of assumptions made for the sake of simplicity, but these can be improved upon to create a more robust
optimization tool.

The *processes.csv* file has been provided as a sample set of processes to import into the application and run it.

## How to Run
1. Load a CSV file from the File menu. The *processes.csv* can be loaded as a sample. Optionally, select the **Forever** option under **Duration** to make the
system run forever.
2. Click on Start Server to start the server up. It should be consuming Idle Power at this point.
3. Click on the Run button to start running the loaded processes or to just run the server at full load indefinitely if **Forever** is selected.
4. Adjust parameters to suit your preferences.

## Known Issues
 - Using the reset button twice breaks the process running queue. Just restart the application.
 - The temperature does not have an upper or lower limit!
