using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigurator.Helpers
{
    public class ResourceHelper
    {
        public static void AddResource(string resxFileName, string name, string value)
        {
            using (var resx = new ResXResourceWriter(String.Format(@".\{0}.resx", resxFileName)))
            {
                resx.AddResource(name, value);
            }
        }

        public static bool ResourceFileExists(string resxFileName)
        {
            return File.Exists(String.Format(@".\{0}.resx", resxFileName));
        }
    }
}
