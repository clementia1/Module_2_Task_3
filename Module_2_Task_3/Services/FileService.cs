using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Module_2_Task_3.Models;

namespace Module_2_Task_3.Services
{
    public class FileService
    {
        private readonly StreamWriter _streamWriter;
        private readonly ConfigService _configService;

        public FileService()
        {
            _configService = new ConfigService();
            var config = _configService.GetConfig();
            var fileName = DateTime.UtcNow.ToString(config.DateTimeFormat);

            if (!Directory.Exists(config.LogsDir))
            {
                Directory.CreateDirectory(config.LogsDir);
            }

            _streamWriter = new StreamWriter($@"{config.LogsDir}\{fileName}{config.FileExtension}", true, Encoding.Default);
        }

        ~FileService()
        {
            _streamWriter.Close();
        }

        public void Write(string text)
        {
            _streamWriter.WriteLine(text);
            _streamWriter.Flush();
        }
    }
}
