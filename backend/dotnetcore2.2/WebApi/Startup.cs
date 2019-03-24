using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JFDIList.DataAccess;
using JFDIList.DataAccess.Repositories;
using JFDIList.Domain.Interfaces;
using JFDIList.Domain.Model.Identity;
using JFDIList.Services.Infrastructure;
using JFDIList.Services.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JFDIList.WebApi
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthenticationCore().AddDbContext<JfdiDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("jfdidbconnection")))
                .AddIdentity<JfdiUser, JfdiRole>()
                .AddEntityFrameworkStores<JfdiDbContext>()
                .AddDefaultTokenProviders();

            services.AddAutoMapper(config=> {
                config.AddProfile<AutoMapperTaskProfile>();
            });

            services.AddScoped<ITasksService, TasksService>();
            services.AddScoped<ITasksRepository, TasksRepository>();


            services.AddCors(options=> {
                options.AddPolicy("jfdiPolisy", builder=>builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("jfdiPolisy");
            app.UseMvc();
        }
    }
}
