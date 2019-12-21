Design
-----------------------------------------------------------------------------------------------
The StatisticsGenerator uses a queue to implement the storage of the input data stream and 
calculates rolling maximum and rolling average using simple loops.


Classes
-----------------------------------------------------------------------------------------------
StatisticsGenerator - stores the input data stream and calculates Max and Avg values for given
window sizes.
StatisticsGeneratorDriver - driver class that validates user inputs prints output to console 
for a given data stream.

Assumptions
-----------------------------------------------------------------------------------------------
1. When the program is run in a command window, the input is in the form: [1, 2, 3, 4, 5, 6]
   Notice that all input values within the [/] are comma separated.
2. For each window size, the output will be of the form Average, Max
3. To successfully calculate statistics values (max, avg): 
    * The StatisticsGenerator class should be initialized with a valid array of window sizes that have 
        values in range (1, int32.MaxValue)
    * The window size is less than or equal to the number of elements in the datastream
4. As per the instructions, the StatisticsGenerator class has been initialized for window sizes (3, 20).


Build and Run
-----------------------------------------------------------------------------------------------

Dotnet core sdk is required to build and run the program.

https://www.microsoft.com/net/core

1. Open a command prompt and create a new folder
2. Navigate to the folder you created and run the following
   dotnet new console
3. Replace the generated Program.cs file with the attached Program.cs file and run the following
   dotnet restore
   dotnet build
   dotnet run


Worst Case Runtime Complexity
-----------------------------------------------------------------------------------------------
Add operation - O(1)
Calculation of Avg/Max operation - O(n) [n = max(Window sizes)]