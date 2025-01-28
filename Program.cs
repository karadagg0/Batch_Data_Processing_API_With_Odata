
using Batch_Data_Processing_API_With_Odata.Context;
using Batch_Data_Processing_API_With_Odata.DbModels;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
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
            var batchHandler = new DefaultODataBatchHandler();
            batchHandler.MessageQuotas.MaxNestingDepth = 2;
            batchHandler.MessageQuotas.MaxOperationsPerChangeset = 10;
            batchHandler.MessageQuotas.MaxReceivedMessageSize = 100;
            builder.Services.AddControllers()
            .AddJsonOptions(i => i.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve)
            .AddOData(opt =>
            {
                opt.AddRouteComponents("api", GetEdmModel(), batchHandler);              
                opt.EnableQueryFeatures();
                //opt.Select().OrderBy().Filter().Expand().Count().SetMaxTop(100);
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
            app.UseODataBatching();
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