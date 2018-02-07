using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace MemoryMappedFileSample
{
    class FileReader
    {
        public static byte[] Read(string path)
        {
            byte[] result;
            using (var memoryMappedFile = MemoryMappedFile.CreateFromFile(path, FileMode.Open))
            {
                using (var memoryMappedViewStream = memoryMappedFile.CreateViewStream())
                {
                    result = new byte[memoryMappedViewStream.Length];
                    memoryMappedViewStream.Read(result, 0, result.Length);
                }
            }
            return result;
        }

        public static void Write(string path,byte[] content)
        {
            using (var memoryMappedFile = MemoryMappedFile.CreateFromFile(path, FileMode.Create, "save", content.Length))
            {
                using (var memoryMappedViewStream = memoryMappedFile.CreateViewStream())
                {
                    memoryMappedViewStream.Write(content, 0, content.Length);
                }
            }
        }
    }
}
