using System;
using System.Collections.Generic;
using System.Text;

namespace MemoryMappedFileSample
{
    class Program
    {
        static void Main(string[] args)
        {
           var bytes = FileReader.Read("MilkyWay.jpg");

            FileReader.Write("MilkyWay002.jpg",bytes );
        }
    }
}
