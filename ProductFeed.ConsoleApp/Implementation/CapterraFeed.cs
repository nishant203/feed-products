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
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ProductFeed.ConsoleApp.Implementation
{
    public class CapterraFeed : IProductFeed
    {
        public List<Product> GetProducts(string path)
        {
            string finalPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
            string yml = File.ReadAllText(finalPath);
            //var deserializer = new DeserializerBuilder()
            //    .WithNamingConvention(UnderscoredNamingConvention.Instance)  // see height_in_inches in sample yml 
            //    .Build();

            ////yml contains a string containing your YAML
            //var p = deserializer.Deserialize<List<CapterraProductModel>>(yml);
            var products = MapToProduct(BaseHelper.DeserializeYaml<List<CapterraProductModel>>(yml));
            return products;
        }
        public List<Product> MapToProduct(List<CapterraProductModel> capterraProductModels)
        {
            return capterraProductModels.ConvertAll(x => new Product { Name = x.Name,Categories = x.Categories, Twitter=x.Twitter });
        }
    }
}
