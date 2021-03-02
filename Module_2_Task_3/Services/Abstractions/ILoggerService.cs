using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_3.Models.Enums;

namespace Module_2_Task_3.Services.Abstractions
{
    public interface ILoggerService
    {
        void Log(LogType type, string message);

        void LogInfo(string message);

        void LogWarning(string message);

        void LogError(string message);
    }
}
