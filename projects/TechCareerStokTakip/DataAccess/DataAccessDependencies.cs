﻿using DataAccess.Context;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

//Extension method : Static class içine yazılması gerekir, veri tabanıyla ilgili bağımlılıkları buraya yazarız
public static class DataAccessDependencies
{
    public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddDbContext<BaseDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("SqlConnection")));

        return services;
    }
}
