using eCommerce.OrderMicroservice.BusinessLogicLayer.DTO;
using FluentValidation;

namespace eCommerce.OrderMicroservice.BusinessLogicLayer.Validators;

public class OrdersUpdateRequestValidator : AbstractValidator<OrderUpdateRequest>
{
    public OrdersUpdateRequestValidator()
    {
        RuleFor(x => x.OrderID).NotEmpty().WithErrorCode("Order ID can't be blank");
        RuleFor(x => x.UserID).NotEmpty().WithErrorCode("UserID can't be blank");
        RuleFor(x => x.OrderDate).NotEmpty().WithErrorCode("OrderDate can't be blank");
        RuleFor(x => x.OrderItems).NotEmpty().WithErrorCode("Order Items can't be blank");
    }
}