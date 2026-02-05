using eCommerce.OrderMicroservice.BusinessLogicLayer.DTO;
using FluentValidation;

namespace eCommerce.OrderMicroservice.BusinessLogicLayer.Validators;

public class OrderItemUpdateRequestValidator : AbstractValidator<OrderItemUpdateRequest>
{
    public OrderItemUpdateRequestValidator()
    {
        RuleFor(x => x.ProductID)
            .NotEmpty().WithErrorCode("ProductID can't be blank");
        RuleFor(x => x.UnitPrice)
            .NotEmpty().WithErrorCode("Unit Price can't be blank")
            .GreaterThan(0).WithErrorCode("Unit Price can't be less than or equal to zero");
        RuleFor(x => x.Quantity)
            .NotEmpty().WithErrorCode("Quantity is required.")
            .GreaterThan(0).WithErrorCode("Quantity must be a positive integer.");
    }
}