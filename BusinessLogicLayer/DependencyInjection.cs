using eCommerce.OrderMicroservice.BusinessLogicLayer.Mapping;
using eCommerce.OrderMicroservice.BusinessLogicLayer.ServiceContracts;
using eCommerce.OrderMicroservice.BusinessLogicLayer.Services;
using eCommerce.OrderMicroservice.BusinessLogicLayer.Validators;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.OrderMicroservice.BusinessLogicLayer;

public static class DependencyInjection
{
    public static IServiceCollection AddBusinessLogicLayer(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your data access layer services here
        // e.g., services.AddScoped<IOrderRepository, OrderRepository>();

        services.AddValidatorsFromAssemblyContaining<OrdersAddRequestValidator>();

        services.AddAutoMapper(cfg => { }, typeof(OrderAddRequestToOrderMappingProfile).Assembly);

        services.AddScoped<IOrdersService, OrdersService>();

        return services;
    }
}