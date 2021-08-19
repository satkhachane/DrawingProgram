using DrawingProgram.Domains;
using DrawingProgram.Interfaces;
using System.Collections.Generic;
using System.Linq;
namespace DrawingProgram.Validators
{
    public class ArgumentCountsValidator : ICommandValidator
    {
        public List<string> ValidationErrors { get; set; }
        public List<char> ApplicableCommands { get; set; }
        Dictionary<char, int> commandArgumentvalidations = new Dictionary<char, int>();
        public ArgumentCountsValidator()
        {
            ValidationErrors = new List<string>();
            ApplicableCommands = new List<char> {
                CommandConstants.Canvas,
                CommandConstants.Line,
                CommandConstants.Reactangle,
                CommandConstants.Quit,
                CommandConstants.BackColor };

            LoadArgumentsCountRules();
        }
        void LoadArgumentsCountRules()
        {
            commandArgumentvalidations.Add(CommandConstants.Canvas, 2);
            commandArgumentvalidations.Add(CommandConstants.Line, 4);
            commandArgumentvalidations.Add(CommandConstants.Reactangle, 4);
            commandArgumentvalidations.Add(CommandConstants.BackColor, 3);
            commandArgumentvalidations.Add(CommandConstants.Quit, 0);
        }
        public bool Validate(ICommand command)
        {
            if (!ApplicableCommands.Contains(command.CommandName))
            {
                return true;
            }

            if (commandArgumentvalidations.Any(item => item.Key == command.CommandName))
            {
                var args = commandArgumentvalidations.FirstOrDefault(item => item.Key == command.CommandName);
                if (args.Value == command.CommandParams.Count)
                {
                    return true;
                }
                else
                {
                    ValidationErrors.Add(string.Format("Invalid arguments provided for command : {0}", command.CommandName));
                }
            }
            return false;
        }
    }
}
