
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace NotYourAverageBicepShoppingApp.CartsRestAPI
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<NotYourAverageBicepShoppingApp.CartsRestAPI.Models.NotYourAverageBicepContext>(
                options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("CRUDConnection"));
                });



            //builder.Services.AddDbContext<NotYourAverageBicepShoppingApp.CartsRestAPI.Models.NotYourAverageBicepContext>(
            //    options =>
            //    {
            //        options.UseSqlServer(builder.Configuration.GetConnectionString("CRUDConnectionProduct"));
            //    });

            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;

            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
