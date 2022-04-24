using ProductFeed.ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFeed.ConsoleApp.Implementation
{
    public class SimpleFactory : ISimpleFactory
    {
        public IProductFeed GetFeedInstance(string feedType)
        {
            IProductFeed productFeed = null;
            switch (feedType)
            {
                case "capterra":
                    productFeed = new CapterraFeed();
                    break;
                case "softwareadvice":
                    productFeed = new SoftwareAdviceFeed();
                    break;
                default:
                    productFeed = new CapterraFeed();
                    break;
            }
            return productFeed;
        }
    }
}
