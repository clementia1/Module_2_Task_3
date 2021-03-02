using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_3.Models;

namespace Module_2_Task_3.Services.Abstractions
{
    public interface IConfigService
    {
        LoggerConfig Read();
    }
}
