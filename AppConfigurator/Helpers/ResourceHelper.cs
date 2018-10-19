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
        public static void UpdateResourceFile(Hashtable data, string resxFileName)
        {
            Hashtable resourceEntries = new Hashtable();
            string path = String.Format(@".\Resources\{0}.resx", resxFileName);

            //Get existing resources
            ResXResourceReader reader = new ResXResourceReader(path);
            ResXResourceWriter resourceWriter = new ResXResourceWriter(path);

            if (reader != null)
            {
                IDictionaryEnumerator id = reader.GetEnumerator();
                foreach (DictionaryEntry d in reader)
                {
                    //Read from file:
                    string val = "";
                    if (d.Value == null)
                        resourceEntries.Add(d.Key.ToString(), "");
                    else
                    {
                        resourceEntries.Add(d.Key.ToString(), d.Value.ToString());
                        val = d.Value.ToString();
                    }

                    //Write (with read to keep xml file order)
                    resourceWriter.AddResource(d.Key.ToString(), val);

                }
                reader.Close();
            }

            //Add new data (at the end of the file):
            Hashtable newRes = new Hashtable();
            foreach (String key in data.Keys)
            {
                if (!resourceEntries.ContainsKey(key))
                {

                    String value = data[key].ToString();
                    if (value == null) value = "";

                    resourceWriter.AddResource(key, value);
                }
            }

            //Write to file
            resourceWriter.Generate();
            resourceWriter.Close();
        }


        public static void AddResource(string resxFileName, string name, string value)
        {
            var filePath = String.Format(@".\Resources\{0}.resx", resxFileName);

            var reader = new ResXResourceReader(filePath);
            var node = reader.GetEnumerator();
            var writer = new ResXResourceWriter(filePath);

            while (node.MoveNext())
            {
                writer.AddResource(node.Key.ToString(), node.Value.ToString());
            }
            var newNode = new ResXDataNode(name, value);
            writer.AddResource(newNode);
            writer.Generate();
            writer.Close();
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
