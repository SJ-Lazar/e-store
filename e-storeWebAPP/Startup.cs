using DataAccessLayer.Context;
using e_storeWebAPP.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP
{
    public class Startup
    {
        #region Constructor
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region Public Variables
        public IConfiguration Configuration { get; }
        #endregion

        #region ConfigureServices
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Controllers
            services.AddControllers();

            services.ConfigureIdentity();

            services.ConfigureDbContext(Configuration);

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "e-store API", Version = "v1" });
            });
        }
        #endregion

        #region HttpPipeline Middleware
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "e_storeWebAPP v1"));

            //Global Error Handling
            app.ConfigureExceptionHandler();

            //Redirections
            app.UseHttpsRedirection();

            //Routing
            app.UseRouting();

            //Authoriazation
            app.UseAuthorization();

            //End Points
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        } 
        #endregion
    }
}
