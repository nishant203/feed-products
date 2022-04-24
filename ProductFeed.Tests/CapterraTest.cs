using ProductFeed.ConsoleApp.Implementation;
using ProductFeed.ConsoleApp.Interfaces;
using ProductFeed.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ProductFeed.Tests
{
    public class CapterraTest
    {
        private readonly IProductFeed _productFeed = null;
        private readonly List<Product> _products = null;
        public CapterraTest()
        {
            _products = new List<Product>()
            {
                new Product()
                {
                    Categories = "Bugs & Issue Tracking,Development Tools",
                    Name = "GitGHub",
                    Twitter = "github"
                },
                new Product()
                {
                    Categories = "Instant Messaging & Chat,Web Collaboration,Productivity",
                    Name = "Slack",
                    Twitter = "slackhq"
                },
                new Product()
                {
                    Categories = "Project Management,Project Collaboration,Development Tools",
                    Name = "JIRA Software",
                    Twitter = "jira"
                }
            };
            _productFeed = new CapterraFeed();
        }

        [Fact]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse()
        {
            var output = _productFeed.GetProducts("feed-products/capterra.yaml");
            Assert.True(_products.All(shouldItem => output.Any(isItem => isItem.Name == shouldItem.Name)));
        }
    }
}
