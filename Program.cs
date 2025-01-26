
using Batch_Data_Processing_API_With_Odata.Context;
using Batch_Data_Processing_API_With_Odata.DbModels;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.NewtonsoftJson;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using System.Text.Json.Serialization;

namespace Batch_Data_Processing_API_With_Odata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllers()
             .AddJsonOptions(i => i.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve)
            .AddOData(opt =>
            {
                opt.AddRouteComponents("api", GetEdmModel());
                //opt.Select().OrderBy().Filter();
                opt.EnableQueryFeatures();
            });
            builder.Services.AddDbContext<UsersDbContext>((sp, conf) =>
            {
                conf.UseSqlServer("Server=localhost;Initial Catalog=OData;Trusted_Connection=False;user ID=sas;Password=1;MultipleActiveResultSets=true;Encrypt=true;TrustServerCertificate=true;");
                conf.EnableSensitiveDataLogging();
            });


             static IEdmModel GetEdmModel()
            {
                var builder = new ODataConventionModelBuilder();
                builder.EntitySet<USERS>("Users");
                builder.EntitySet<ORDERS>("Orders");
                return builder.GetEdmModel();
            }


            var app = builder.Build();
            app.UseRouting();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();

            app.MapControllers(); 

            app.Run();
        }
    }
}