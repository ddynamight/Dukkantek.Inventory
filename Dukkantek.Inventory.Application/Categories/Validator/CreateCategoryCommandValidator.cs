using FluentValidation;
using Dukkantek.Inventory.Application.Categories.Command;

namespace Dukkantek.Inventory.Application.Categories.Validator
{
     public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
     {
          public CreateCategoryCommandValidator()
          {
               RuleFor(e => e.Name).NotEmpty().NotNull().WithMessage("{PropertyName} cannot be null or empty");
          }
     }
}