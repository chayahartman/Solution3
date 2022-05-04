using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
   public static class IServiceCollectionExtensions
    {

        public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection, IConfiguration config)
        {
            serviceCollection.AddScoped<ICategoriesRepository, CategoryRepository>();
            serviceCollection.AddScoped<IClothesRepository, ClothesRepository>();
            serviceCollection.AddScoped<ICustomersRepository, CustomersRepository>();
            serviceCollection.AddScoped<ISalesRepository, SalesRepository>();
            serviceCollection.AddScoped<ISalesDetailsRepository, SalesDetailsRepository>();
            serviceCollection.AddDbContext<clothes_storeContext>(opt => opt.UseSqlServer(config.GetConnectionString("Clothes_Store")));
            return serviceCollection;
        }
    }
}
