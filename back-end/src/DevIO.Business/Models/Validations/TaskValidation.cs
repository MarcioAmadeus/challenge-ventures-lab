using FluentValidation;

namespace DevIO.Business.Models.Validations
{
    public class TaskValidation : AbstractValidator<TaskManagement>
    {
        public TaskValidation()
        {
            RuleFor(c => c.UserId)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
            
        }
    }
}