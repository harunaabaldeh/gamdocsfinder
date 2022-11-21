using Application.Documents.Common;
using Application.Documents.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddApplicationServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("DafaultConnection"));
            });

            builder.Services.AddCors(options => options.AddPolicy("CorsPolicy", policy =>
            {
                policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            }));


            builder.Services.AddMediatR(typeof(DocumentsQuery.Handler).Assembly);
            builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);

        }
    }

}