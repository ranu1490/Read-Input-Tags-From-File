using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInputTags
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInputTags file = new ReadInputTags();
            file.ReadFile();
            Console.Read();
        }
    }
}
