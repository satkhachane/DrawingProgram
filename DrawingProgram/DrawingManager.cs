using DrawingProgram.CommandParsers;
using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using DrawingProgram.Processors;
using DrawingProgram.Validators;
using System;
using System.Collections.Generic;

namespace DrawingProgram
{
    public class DrawingManager
    {
        public static Canvas MainCanvas = null;
        public static void Start()
        {
            try
            {
                ApplicationInformation.PrintApplicationRules();
                StartProcessingCommands();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception occured while processing commands. Once entered the application will get closed.");
                Console.WriteLine("Error details: {0}", exp.Message);
            }
        }

        static void StartProcessingCommands()
        {
            string commandText = string.Empty;
            do
            {
                Console.Clear();
                PrintCanvas();
                commandText = ConsoleCommandReader.GetCommand();
                ParseAndProcessCommand(commandText);

            } while (commandText != "Q");
        }

        static void PrintCanvas()
        {
            if (MainCanvas != null)
            {
                CanvasConsoleWriter canvasConsoleWriter = new CanvasConsoleWriter(MainCanvas);
                canvasConsoleWriter.WriteOnConsole();
            }
        }

        public static void ParseAndProcessCommand(string commandText)
        {
            try
            {
                ICommandParser commandParser = CommandParserFactory.GetCommandParser(commandText);
                if (commandParser != null)
                {
                    ICommand command = commandParser.ParseCommand();
                    List<string> errors = CommandValidationFactory.ValidateCommand(command);
                    if (errors != null && errors.Count > 0)
                    {
                        Console.WriteLine("Validation errors are found in processing command. \nHence processing for this command will be skipped.");
                        Console.WriteLine(string.Join("\n", errors));
                        Console.ReadLine();
                    }
                    else
                    {
                        ICommandProcessor processor = CommandProcessorFactory.GetCommandProcessor(command);
                        processor.ProcessCommand(command, ref MainCanvas);
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine("Exception occured while parsing and processsing command.\n You can continue with next command. Please enter to continue..");
                Console.WriteLine("Error details: {0}", exp.Message);
                Console.ReadLine();
            }
        }
    }
}
