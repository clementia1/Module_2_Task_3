using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_3.Services;
using Module_2_Task_3.Models;

namespace Module_2_Task_3
{
    public class Starter
    {
        public void Run()
        {
            var loggerService = new LoggerService();
            var actions = new Actions();
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                var minRandomNumber = 0;
                var maxRandomNumber = 3;
                var randomNumber = random.Next(minRandomNumber, maxRandomNumber);

                try
                {
                    switch (randomNumber)
                    {
                        case 0:
                            actions.InfoMethod();
                            break;
                        case 1:
                            actions.WarningMethod();
                            break;
                        case 2:
                            actions.ErrorMethod();
                            break;
                    }
                }
                catch (BusinessException businessException)
                {
                    loggerService.LogWarning($"Action got this custom Exception: {businessException}");
                }
                catch (Exception exception)
                {
                    loggerService.LogError($"Action failed by reason: {exception}");
                }
            }
        }
    }
}
