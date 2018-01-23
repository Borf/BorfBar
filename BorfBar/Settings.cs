using BorfBar.modules;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorfBar
{
    static class Settings
    {
        public static List<Module> Modules = new List<Module>();
        public static Color backgroundColor = Color.FromArgb(38, 37, 36);
        public static Color borderColor = Color.FromArgb(152, 151, 150);
        public static Color textColor = Color.FromArgb(255, 255, 255);


        public static void save()
        {
            File.WriteAllText("save.json", JsonConvert.SerializeObject(Modules, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            }));
        }

        public static void load()
        {
            try
            {
                Modules = JsonConvert.DeserializeObject<List<Module>>(File.ReadAllText("save.json"), new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
