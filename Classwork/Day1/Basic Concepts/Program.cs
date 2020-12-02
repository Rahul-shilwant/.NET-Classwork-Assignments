using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Program1
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello Rahul.....");

            program2 p2 = new program2();
            p2.show();
            Console.ReadLine();
        }
    
    }
    
    public class program2
    {

          public void show()
        {
            Console.WriteLine("hello from program 2 ");
        }


    }


}

//namespace BasicClassConcepts2
//{

    
//}
