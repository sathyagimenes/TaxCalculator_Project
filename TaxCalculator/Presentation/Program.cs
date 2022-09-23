using System;
using Microsoft.Extensions.DependencyInjection;
using MyTaxCalculator.Presentation.Screens;
using MyTaxCalculator.Services;
using MyTaxCalculator.Domain;


namespace MyTaxCalculator
{
    public class Program
    {
        public static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();
            var screen = serviceProvider.GetService<IScreenFlow>();

            screen.ExecuteFlow();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<IScreenFlow, ScreenFlow>()
                .AddScoped<ITaxCalculator, TaxCalculator>()
                .AddScoped<ITiers, Tiers>();
        }
    }
}