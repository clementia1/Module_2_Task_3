using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_3.Models;

namespace Module_2_Task_3.Services
{
    public class Actions
    {
        private readonly LoggerService _loggerService;

        public Actions()
        {
            _loggerService = new LoggerService();
        }

        public bool InfoMethod()
        {
            _loggerService.LogInfo($"Start method: {nameof(InfoMethod)}");
            return true;
        }

        public bool WarningMethod()
        {
            throw new BusinessException("Skipped logic in method");
        }

        public bool ErrorMethod()
        {
            throw new Exception("I broke a logic");
        }
    }
}
