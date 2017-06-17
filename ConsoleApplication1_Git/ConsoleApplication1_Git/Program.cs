using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1_Git
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            Console.Write(Directory.GetCurrentDirectory() + ">");
            command = Console.ReadLine().ToLower();
            if (command == "hostname")
            {
                 Console.WriteLine(Environment.OSVersion);
                Console.ReadKey();
            }



        }
    }
}
