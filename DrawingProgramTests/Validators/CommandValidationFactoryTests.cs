using DrawingProgram.CommandParsers;
using DrawingProgram.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DrawingProgram.Validators.Tests
{
    [TestClass()]
    public class CommandValidationFactoryTests
    {
        [TestMethod()]
        [DataRow("C 20 10", 2)]
        [DataRow("B 5 10 c", 3)]
        [DataRow("L 5 5 5 10", 4)]
        [DataRow("R 5 5 10 10", 4)]
        public void ValidateCommandTest(string commandText, int numberOfArguments)
        {
            ICommandParser parser = new CommandParser(commandText);
            ICommand command = parser.ParseCommand();
            List<string> errors = CommandValidationFactory.ValidateCommand(command);
            Assert.AreEqual(errors.Count,0,"Validation factory is not validating the command properly.");
        }
    }
}