using System;

namespace DrawingProgram
{
    public class ApplicationInformation
    {
        public static void PrintApplicationRules()
        {
            Console.WriteLine("*****  Drawing on console by sequntial commands ******\n\n");
            Console.WriteLine("\nUser can follow below steps while using the application.");
            Console.WriteLine("\n1. Create canvas by command C simillar to Command: {C 10 10}");
            Console.WriteLine("\n2. Use command R - For reactangle L - For Line and B - For paint fill effect ");
            Console.WriteLine("\n3. Use Command Q for quit the application.");
            Console.WriteLine("\n\nSample rectangle command: {R 2 2 10 10}");
            Console.WriteLine("\nSample verticle line command: {L 2 5 2 10}");
            Console.WriteLine("\nSample horizonatle line command: {L 5 3 8 3}");
            Console.WriteLine("\n\nPress to continue....");
            Console.ReadLine();
        }
    }
}
