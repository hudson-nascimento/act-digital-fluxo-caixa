using AutoMapper;
using FluxoCaixa.Domain.Dtos;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Infrastructure.Data.Settings;
using Microsoft.OpenApi.Models;

namespace FluxoCaixa.Api.Configurations
{
    /// <summary>
    /// Configuração da API (Application Programming Interface)
    /// </summary>
    public static class ApiConfig
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration);
            services.AddCors();
            _ = services.AddControllers(config =>
            {

            });
            services.AddHttpContextAccessor();

            return services;
        }

        #region Automapper Configuration
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var config = new MapperConfiguration(options =>
            {
                options.CreateMap<WalletDto, Wallet>();
                options.CreateMap<Wallet, WalletDto>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
        #endregion

        public static IApplicationBuilder UseConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseCors(policy => policy
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());

                app.UseAuthentication();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(policy => policy
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }

        #region Swagger Configuration
        public static IServiceCollection AddSwagger(this IServiceCollection services, string appName, string version = "v1")
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(version, new OpenApiInfo { Title = $"{appName} - {Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}", Version = version });
                c.MapType<DateOnly>(() => new OpenApiSchema
                {
                    Type = "string",
                    Format = "date"
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Adicione um token válido.",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerWithUI(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            return app;
        }
        #endregion
    }
}
