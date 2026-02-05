using eCommerce.OrderMicroservice.BusinessLogicLayer.DTO;
using FluentValidation;

namespace eCommerce.OrderMicroservice.BusinessLogicLayer.Validators;

public class  OrdersAddRequestValidator : AbstractValidator<OrderAddRequest>
{
    public OrdersAddRequestValidator()
    {
        RuleFor(x => x.UserID).NotEmpty().WithErrorCode("UserID can't be blank");
        RuleFor(x => x.OrderDate).NotEmpty().WithErrorCode("OrderDate can't be blank");
        RuleFor(x => x.OrderItems).NotEmpty().WithErrorCode("Order Items can't be blank");
    }
}