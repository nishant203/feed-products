using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFeed.ConsoleApp.Interfaces
{
    public interface IDbContext<T> where T : class
    {
        Task<List<T>> GetAsync();
        Task CreateAsync(T playlist);
        Task DeleteAsync(string id);
    }
}
