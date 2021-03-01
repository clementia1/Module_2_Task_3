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
        public void Log(Logger logger, LogType type, string message)
        {
            var timeStamp = DateTime.UtcNow;
            var consoleMessage = $"{timeStamp}: {type}: {message}";
            Console.WriteLine(consoleMessage);

            HistoryAppend(logger, message);
        }

        public void LogInfo(Logger logger, string message)
        {
            Log(logger, LogType.Info, message);
        }

        public void LogWarning(Logger logger, string message)
        {
            Log(logger, LogType.Warning, message);
        }

        public void LogError(Logger logger, string message)
        {
            Log(logger, LogType.Error, message);
        }

        public void HistoryAppend(Logger logger, string message)
        {
            logger.History.AppendLine(message);
        }

        public string GetHistory(Logger logger)
        {
            return logger.History.ToString();
        }
    }
}
