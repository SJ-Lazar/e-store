using DataAccessLayer.Context;
using DataDomain.DataTables.Base;
using e_storeWebAPP.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.Extensions
{
    public static class ServiceExtensions
    {
        #region Services Configure Methods
        public static void ConfigureCors(this IServiceCollection services)
        {
            //Cors Service
            services.AddCors(c => {
                c.AddPolicy("AllowAllPolicy",
                    builder =>
                        builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader());
            });
        }
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration Configuration)
        {
            //DbContext Service
            services.AddDbContext<eStoreDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("eStoreSqlCon"))
            );
        }
        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<User>(q =>
            {
                q.Password.RequireDigit = false;
                q.Password.RequiredLength = 4;
                q.Password.RequireLowercase = false;
                q.Password.RequireUppercase = false;
                q.Password.RequiredUniqueChars = 0;
                q.Password.RequireNonAlphanumeric = false;
                q.User.RequireUniqueEmail = true;

            });

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<eStoreDbContext>();

        }
        public static void ConfigureExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        Log.Error($"Something Went Wrong in the {contextFeature.Error}");
                        await context.Response.WriteAsync(new Error
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error. Please Try Again Later."
                        }.ToString());
                    }
                });

            });
        } 
        #endregion
    }


}
