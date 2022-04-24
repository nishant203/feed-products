using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ProductFeed.ConsoleApp.Helpers
{
    public static class BaseHelper
    {
        public static T DeserializeYaml<T>(string yml)
           where T : class
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(UnderscoredNamingConvention.Instance)  // see height_in_inches in sample yml 
                .Build();

            //yml contains a string containing your YAML
            var data = deserializer.Deserialize<T>(yml);
            return data;
        }
    }
}
