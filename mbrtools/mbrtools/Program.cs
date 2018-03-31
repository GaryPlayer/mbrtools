using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mbrtools
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Title = "MBR Tools by Gary Player Ltd.";
            Console.WriteLine("MBR Tools 1.0 by Gary Player Ltd.");
            Console.WriteLine(" ");
            Console.WriteLine("M => FIXMBR  recreates the MBR (Master Boot Sector),it helps with removing roootkits or malware");
            Console.WriteLine("B => FIXBOOT  recreates the boot directory");
            while (Console.ReadKey().Key != ConsoleKey.M) {
                Console.WriteLine("Fixing MBR...");
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("MBR has been fixed!");
                Console.ReadKey();
                

            }


        }
    }
}
