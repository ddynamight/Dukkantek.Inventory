using FluentValidation;
using Dukkantek.Inventory.Application.Categories.Command;

namespace Dukkantek.Inventory.Application.Categories.Validator
{
     public class DeleteCategoryCommandValidator : AbstractValidator<DeleteCategoryCommand>
     {
          public DeleteCategoryCommandValidator()
          {
               RuleFor(e => e.Id).NotEmpty().NotNull().WithMessage("{PropertyName} cannot be null or empty");
          }
     }
}