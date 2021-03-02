using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Module_2_Task_3.Models;
using Module_2_Task_3.Config;

namespace Module_2_Task_3.Services
{
    public class ConfigService
    {
        public LoggerConfig Read()
        {
            var configFile = File.ReadAllText(Constants.ConfigPath);
            var config = JsonConvert.DeserializeObject<LoggerConfig>(configFile);
            return config;
        }
    }
}
