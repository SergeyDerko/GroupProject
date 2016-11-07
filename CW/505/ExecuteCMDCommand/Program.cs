using System;
using System.Diagnostics;

namespace ExecuteCMDCommand
{
    class Program
    {
        static void ExecuteCommand(string command)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            // *** Redirect the output ***

            var process = Process.Start(processInfo);
            if (process != null)
            {
                process.WaitForExit();

                // *** Read the streams ***
                // Warning: This approach can lead to deadlocks, see Edit #2
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                var exitCode = process.ExitCode;

                Console.WriteLine("output>>" + (string.IsNullOrEmpty(output) ? "(none)" : output));
                Console.WriteLine("error>>" + (string.IsNullOrEmpty(error) ? "(none)" : error));
                Console.WriteLine("ExitCode: " + exitCode, "ExecuteCommand");
                process.Close();
            }
        }

        static void Main()
        {
            ExecuteCommand("echo testing");
        }
    }
}
