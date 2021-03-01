using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_3.Models.Enums;

namespace Module_2_Task_3.Models
{
    public class Logger
    {
        static Logger()
        {
            History = new StringBuilder();
        }

        public static StringBuilder History { get; set; }
    }
}
