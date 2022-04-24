using ProductFeed.ConsoleApp.Interfaces;
using ProductFeed.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFeed.ConsoleApp.Implementation
{
    public class MongoDbService : IDbContext<Product>
    {
        public MongoDbService()
        {
            /// Create connection object
        }

        public Task CreateAsync(Product playlist)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
