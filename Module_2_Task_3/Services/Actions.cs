using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /*
        public Result FakeMethodWithWarning()
        {
            var result = new Result { Status = true };
            _logger.WriteMessage($"Skipped logic in method: {nameof(FakeMethodWithWarning)}", EventType.Warning);
            return result;
        }

        public Result FakeMethodWithError()
        {
            var result = new Result { Status = false, ErrorMessage = "I broke a logic" };
            return result;
        }*/
    }
}
