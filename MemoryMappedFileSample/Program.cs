using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryMappedFileSample
{
    class Program
    {
        static void Main(string[] args)
        {
           var bytes = FileProcessor.Read("MilkyWay.jpg");

            FileProcessor.Write("MilkyWay002.jpg",bytes );
        }
    }
}
