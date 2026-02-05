using eCommerce.OrderMicroservice.DataAccessLayer.Repositories;
using eCommerce.OrderMicroservice.DataAccessLayer.RepositoryContracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace eCommerce.OrderMicroservice.DataAccessLayer;

public static class DependencyInjection
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
    {
        // Register your data access layer services here
        // e.g., services.AddScoped<IOrderRepository, OrderRepository>();

        string connectionStringTemplate = configuration.GetConnectionString("MongoDB")!;
        string connectionString = connectionStringTemplate
            .Replace("$MONGO_HOST", Environment.GetEnvironmentVariable("MONGODB_HOST"))
            .Replace("$MONGO_PORT", Environment.GetEnvironmentVariable("MONGODB_PORT"));

        services.AddSingleton<IMongoClient>(new MongoClient(connectionString));
        services.AddScoped<IMongoDatabase>(provider =>
        {
            var mongoClient = provider.GetRequiredService<IMongoClient>();
            return mongoClient.GetDatabase("OrdersDatabase");
        });

        services.AddScoped<IOrdersRepository, OrdersRepository>();

        return services;
    }
}