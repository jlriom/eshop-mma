using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eshop.Basket;

public static class BasketModule
{
    public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration) 
    {

        return services;
    }

        public static IApplicationBuilder UseBasketModule(this IApplicationBuilder applicationBuilder) 
    {

        return applicationBuilder;
    }


}
