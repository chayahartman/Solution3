using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Services;


using Newtonsoft.Json.Serialization;

namespace Clothe_Store
{
    public class Startup
    {
        
        IConfiguration config;
        public Startup(IConfiguration config)
        {
            this.config = config;
        }


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(c => { c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddServices(config);

            //services.           .AddNewtonsoftJson(opsions =>
            // opsions.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
            //     .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
            //     = new DefaultContractResolver());
            //services.AddControllers();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }


            // app.UseRouting();

            // global cors policy
            //app.UseCors(builder =>
            //{
            //    builder
            //    .AllowAnyOrigin()
            //    .AllowAnyMethod()
            //    .AllowAnyHeader();
            //});

            app.UseAuthentication();
           

            //app.UseEndpoints(x => x.MapControllers());

            app.UseHttpsRedirection();
            app.UseMvc();
           // app.UseCors();

           
        }
    }
}
