using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{


    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("VALUE IS=" + args[i]);

            }
            Console.ReadLine();
        }
    }
    class student
    {
        static void Main(string[] args)
        {
            if (args[0] == "user" && args[1] == "pass")
            {
                Console.WriteLine("welcome user");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("invalid  user");
                Console.ReadLine();
            }
        }

    }




}
