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
        private readonly LoggerConfig _config;
        private readonly string _filename;
        private StreamWriter _streamWriter;

        public FileService()
        {
            _config = new ConfigService().Read();
            _filename = DateTime.UtcNow.ToString(_config.DateTimeFormat);

            CreateDirIfNotExists(_config.LogsDir);
            CountFilesInDir(_config.LogsDir);
        }

        ~FileService()
        {
            _streamWriter.Close();
        }

        public void Write(string text)
        {
            using (_streamWriter = new StreamWriter($@"{_config.LogsDir}\{_filename}{_config.FileExtension}", true, Encoding.Default))
            {
                _streamWriter.WriteLine(text);
            }
        }

        public void CreateDirIfNotExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void CountFilesInDir(string path)
        {
            var fileNames = Directory.GetFiles(path);
            var creationTimes = new DateTime[fileNames.Length];
            for (int i = 0; i < fileNames.Length; i++)
            {
                creationTimes[i] = new FileInfo(fileNames[i]).CreationTime;
            }

            Array.Sort(creationTimes, fileNames);

            for (int i = 0; i < fileNames.Length; i++)
            {
                Console.WriteLine(fileNames[i]);
            }
        }
    }
}
