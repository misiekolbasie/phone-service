using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PhoneService.DataAccess;
using PhoneService.DataAccess.Interfaces;
using PhoneService.MiddleWare;
using PhoneService.Services;
using PhoneService.Services.Interfaces;

namespace PhoneService
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)//box with definisions
        {
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddTransient<IPhoneShopService, PhoneShopService>();
            services.AddTransient<IPhoneRepository, PhoneRepository>();
            services.AddDbContext<PhoneContext>(options =>
                options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=PhoneDb;Trusted_Connection=True;", b => b.MigrationsAssembly("PhoneService.DataAccess")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseMiddleware<SimpleMiddleware>();


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
           


        }
    }
}
