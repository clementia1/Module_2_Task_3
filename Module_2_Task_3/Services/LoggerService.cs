using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_3.Models;
using Module_2_Task_3.Models.Enums;

namespace Module_2_Task_3.Services
{
    public class LoggerService
    {
        private readonly FileService _fileService;

        public LoggerService()
        {
            _fileService = new FileService();
        }

        public void Log(LogType type, string message)
        {
            var consoleMessage = $"{DateTime.UtcNow}: {type}: {message}";
            _fileService.Write(consoleMessage);
        }

        public void LogInfo(string message)
        {
            Log(LogType.Info, message);
        }

        public void LogWarning(string message)
        {
            Log(LogType.Warning, message);
        }

        public void LogError(string message)
        {
            Log(LogType.Error, message);
        }
    }
}
