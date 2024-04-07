using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SC4_Launcher
{
    public class Prog_data
    {
        public Version version = new Version("1.2.0");
        public bool hidden_mode = false;
        public int profile = 0;
        public bool autores = false;
        const string BuildVersionMetadataPrefix = "+build";
        const string dateFormat = "yyyy-MM-ddTHH:mm:ss:fffZ";

        public DateTime GetLinkerTime(Assembly assembly)
        {
            var attribute = assembly
              .GetCustomAttribute<AssemblyInformationalVersionAttribute>();

            if (attribute?.InformationalVersion != null)
            {
                var value = attribute.InformationalVersion;
                var index = value.IndexOf(BuildVersionMetadataPrefix);
                if (index > 0)
                {
                    value = value[(index + BuildVersionMetadataPrefix.Length)..];

                    return DateTime.ParseExact(
                        value,
                      dateFormat,
                      CultureInfo.InvariantCulture);
                }
            }
            return default;
        }
    }
}
