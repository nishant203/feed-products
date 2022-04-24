using Newtonsoft.Json;
using ProductFeed.ConsoleApp.Helpers;
using ProductFeed.ConsoleApp.Interfaces;
using ProductFeed.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductFeed.ConsoleApp.Implementation
{
    public class SoftwareAdviceFeed : IProductFeed
    {
        public List<Product> GetProducts(string path)
        {
            string finalPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
            string json = File.ReadAllText(finalPath);
            var products = MapToProduct(JsonConvert.DeserializeObject<List<SoftwareAdviceProductModel>>(json));
            return products;
        }

        private List<Product> MapToProduct(List<SoftwareAdviceProductModel> softwareAdviceFeeds)
        {
            /// can also use libs like automapper to make life easier.
            return softwareAdviceFeeds.ConvertAll(x => new Product { Name = x.Name, Categories = x.Categories, Twitter = x.Twitter });
        }
    }
}
