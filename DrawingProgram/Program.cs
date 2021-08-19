using System;

namespace DrawingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingManager.Start();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("Unhandled exception: " + e.ToString());
            Console.ReadLine();

        }
    }
}
