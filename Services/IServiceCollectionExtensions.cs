using AutoMapper;
using AutoMapper.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services.Profiles;
using System;
using System.Collections.Generic;
using System.Text;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace Services
{
   public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection serviceCollection, IConfiguration config)
        {
            serviceCollection.AddScoped<ICategoriesService, CategoriesService>();
            serviceCollection.AddScoped<IClothesService, ClothesService>();
            serviceCollection.AddScoped<ICustomersService, CustomersService>();
            serviceCollection.AddScoped<IBuyingService, BuyingService>();
            //added as scoped service - scoped is a shorter lifetime than singleton
            //thereore repository will be added in scoped lifetime (and therefore services too)
            serviceCollection.AddRepositories(config);
            serviceCollection.AddAutoMapper(typeof(CategoryProfile));
            serviceCollection.AddAutoMapper(typeof(ClothesProfile));
            serviceCollection.AddAutoMapper(typeof(CustomersProfile));
            return serviceCollection;
        }
    }
}
