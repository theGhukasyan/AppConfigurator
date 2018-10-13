using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;


namespace AppConfigurator.Helpers
{
    public class ResourceHelper
    {
        public static void AddResource(string resxFileName, string name, string value)
        {
            using (var resx = new ResXResourceWriter(String.Format(@".\Resources\{0}.resx", resxFileName)))
            {
                resx.AddResource(name, value);
            }
        }

        public static bool ResourceFileExists(string resxFileName) =>
            File.Exists(String.Format(@".\Resources\{0}.resx", resxFileName));

        public static Dictionary<string, string> GetResource(string key, string resxFileName)
        {
            var resource = new Dictionary<string, string>();
            var resx = new ResXResourceReader(String.Format(@".\Resources\{0}.resx", resxFileName));

            foreach (DictionaryEntry item in resx)
                resource.Add(item.Key.ToString(), item.Value.ToString());

            return resource;
        }

        public static string[] GetFileNames() => 
            Directory.GetFiles(@".\Resources", "*.resx").Select(Path.GetFileName).ToArray();
    }
}
