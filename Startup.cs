using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using money_manager_server.Entities;
namespace money_manager_server
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddCors(options =>
        {
            // CorsPolicy 是自訂的 Policy 名稱
            options.AddPolicy("CorsPolicy", policy =>
            {
                policy.WithOrigins("https://peng-money-manager-client.herokuapp.com") //("https://peng-money-manager-client.herokuapp.com")
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
        });
      // services.AddDbContext<DBContext>(options =>
      // {
      //   options.UseMySQL(Configuration.GetConnectionString("SQLConnectionString"));
      // });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

      app.UseCors("CorsPolicy");

      //dbContext.Database.EnsureCreated();
    }
  }
}
