using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class TaskValidation : AbstractValidator<TaskManagement>
    {
        public TaskValidation()
        {
            RuleFor(c => c.UserId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.Date)
               .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.StartTime)
              .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.EndTime)
              .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.Subject)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(c => c.Description)
             .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

        }
    }
}