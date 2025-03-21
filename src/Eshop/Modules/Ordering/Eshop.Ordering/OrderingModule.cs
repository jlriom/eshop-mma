﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eshop.Ordering;

public static class OrderingModule
{
    public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration) 
    {

        return services;
    }

    public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder applicationBuilder) 
    {

        return applicationBuilder;
    }


}
