using System; 
using Serilog;

class Program
{
    static void Main()
    {
        // Configure Serilog to write logs to the console and a rolling log file
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.File("log-.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
            Log.Information("Information message: Before Calculation");
            // Simulate division by zero to trigger an error
            int zeroVal = 0;
            int result = (10 / zeroVal);
        }
        catch (Exception ex)
        {
            // Log the error to the console and the log file
            Log.Error(ex, "Error occurred: Divide by zero");
            Environment.Exit(1);
        }
        finally
        {
            Log.CloseAndFlush();
        }

        // Log an information message to the console and the log file
        Log.Information("Information message: Application started successfully");
    }
}

