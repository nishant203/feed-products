using ProductFeed.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFeed.ConsoleApp.Interfaces
{
    public interface IProductFeed
    {
        List<Product> GetProducts(string path);
    }
}
