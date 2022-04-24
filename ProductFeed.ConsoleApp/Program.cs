using Microsoft.Extensions.DependencyInjection;
using ProductFeed.ConsoleApp.Implementation;
using ProductFeed.ConsoleApp.Interfaces;
using ProductFeed.ConsoleApp.Models;
using System;
using System.Collections.Generic;

namespace ProductFeed.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string feedType="", pathName = "";
            if (args.Length == 0)
            {
                feedType = "capterra";
                pathName = "feed-products/capterra.yaml";

            }
            else
            {
                feedType = args[0];
                pathName = args[1];
            }
            var serviceProvider = GetServiceProvider().BuildServiceProvider();
            var factory = serviceProvider.GetService<ISimpleFactory>();
            var feedInstance = factory.GetFeedInstance(feedType);
            var products = feedInstance.GetProducts(pathName);
            PrintProducts(products);
            Console.ReadLine();
        }

        private static void PrintProducts(List<Product> products)
        {
           foreach(var p in products)
           {
                Console.WriteLine($"importing: Name: {p.Name};  Categories: {p.Categories}; Twitter: {p.Twitter};");
           }
        }

        private static IServiceCollection GetServiceProvider()
        {
            var serviceProvider = new ServiceCollection()
                        .AddTransient<ISimpleFactory, SimpleFactory>()
                        .AddTransient(typeof(IDbContext<>), typeof(MySQLService<>));
            return serviceProvider;
        }
    }
}
