using System;
using Microsoft.Extensions.DependencyInjection;
using Service.Models;

namespace Service.Extensions
{
    public static class MyExtensions
    {
        public static IServiceCollection AddVersionInfo(this IServiceCollection services)
        {
            VersionInfo vs = new VersionInfo();
            vs.Desktop = Environment.GetEnvironmentVariable("DESKTOP_VERSION");
            vs.Mobile = Environment.GetEnvironmentVariable("MOBILE_VERSION");
            vs.Web = Environment.GetEnvironmentVariable("WEB_VERSION");

            if(vs.Desktop == null  || vs.Mobile == null || vs.Web == null)
            {
                Console.WriteLine("Ensure All Version Environment variables are set");
                Environment.Exit(1);
            }
            services.AddSingleton(vs);
            return services;
        }

    }
}