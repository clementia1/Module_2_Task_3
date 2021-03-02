using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Module_2_Task_3.Models;
using Module_2_Task_3.Services.Abstractions;

namespace Module_2_Task_3.Services
{
    public class FileService : IFileService
    {
        private readonly LoggerConfig _config;
        private readonly string _filename;
        private StreamWriter _streamWriter;

        public FileService()
        {
            _config = new ConfigService().Read();
            _filename = DateTime.UtcNow.ToString(_config.DateTimeFormat);

            CreateDirIfNotExists(_config.LogsDir);
            RemoveOldFiles(_config.LogsDir, 3);
        }

        public void WriteLine(string text)
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

        public void RemoveOldFiles(string path, int keepLast)
        {
            var fileNames = Directory.GetFiles(path);
            var creationTimes = new DateTime[fileNames.Length];

            for (int i = 0; i < fileNames.Length; i++)
            {
                creationTimes[i] = new FileInfo(fileNames[i]).CreationTime;
            }

            Array.Sort(creationTimes, fileNames);

            for (int i = 0; i < fileNames.Length - keepLast; i++)
            {
                File.Delete(fileNames[i]);
            }
        }
    }
}
