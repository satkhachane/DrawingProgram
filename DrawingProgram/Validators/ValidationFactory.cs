using DrawingProgram.Interfaces;
using System.Collections.Generic;

namespace DrawingProgram.Validators
{
    public static class CommandValidationFactory
    {
        static List<ICommandValidator> commandValidators = new List<ICommandValidator>();
        static CommandValidationFactory()
        {
            commandValidators.Add(new ArgumentCountsValidator());
        }

        public static List<string> ValidateCommand(ICommand command)
        {
            List<string> errors = new List<string>();
            foreach (var validator in commandValidators)
            {
                if (!validator.Validate(command))
                {
                    errors.AddRange(validator.ValidationErrors);
                }
            }
            return errors;
        }
    }
}
