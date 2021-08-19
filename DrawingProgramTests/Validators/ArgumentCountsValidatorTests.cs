using DrawingProgram.CommandParsers;
using DrawingProgram.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DrawingProgram.Validators.Tests
{
    [TestClass()]
    public class ArgumentCountsValidatorTests
    {
        [TestMethod()]
        [DataRow("C 20 10", 0)]
        [DataRow("B 5 10 c 121", 1)]
        public void ValidateArgumentValidatorTest(string commandText, int errors)
        {
            ICommandParser parser = new CommandParser(commandText);
            ICommand command = parser.ParseCommand();
            ICommandValidator validator = new ArgumentCountsValidator();
            validator.Validate(command);
            Assert.AreEqual(validator.ValidationErrors.Count, errors, "Validation factory is not validating the command properly.");
        }
    }
}