using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Module_2_Task_3.Models;

namespace Module_2_Task_3.Services
{
    public class ConfigService
    {
        public LoggerConfig GetConfig()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Config\config.json");
            var configFile = File.ReadAllText(path);
            var config = JsonConvert.DeserializeObject<LoggerConfig>(configFile);
            return config;
        }
    }
}
