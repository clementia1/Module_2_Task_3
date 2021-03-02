using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3.Services.Abstractions
{
    public interface IFileService
    {
        void WriteLine(string text);

        void CreateDirIfNotExists(string path);

        void RemoveOldFiles(string path, int keepLast);
    }
}
