using System;
namespace DrawingProgram
{
    public class ConsoleCommandReader
    {
        public static string GetCommand()
        {
            Console.WriteLine("Enter the command for processing:\n");
            string command = Console.ReadLine();
            return command;
        }
    }
}
