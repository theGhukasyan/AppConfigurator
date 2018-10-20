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
        public static void AddResource(string resxFileName, string name, object value)
        {
            var fileName = $@".\Resources\{resxFileName}.resx";

            using (var writer = new ResXResourceWriter(fileName))
            {
                if (File.Exists(fileName))
                {
                    using (var reader = new ResXResourceReader(fileName))
                    {
                        var node = reader.GetEnumerator();
                        while (node.MoveNext())
                        {
                            writer.AddResource(node.Key.ToString(), node.Value);
                        }
                    }
                }

                writer.AddResource(name, value);
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
