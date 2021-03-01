using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_2_Task_3.Services;

namespace Module_2_Task_3
{
    public class Starter
    {
        public void Run()
        {
            /*Console.WriteLine(DateTime.UtcNow.ToString("hh:mm:ss dd-MM-yyyy"));*/

            var fileService = new FileService();
            fileService.Write("test");
            fileService.Write("test");
            fileService.Write("test");
        }
    }
}
