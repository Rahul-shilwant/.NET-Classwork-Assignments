using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{
    class Namespace1
    {

        public static void Main()
        {

            demo d = new demo();
            d.show();


            n1.n2.demo d1 = new n1.n2.demo();
            d1.show();



        }
        class demo
        {

           public void show()
            {

                Console.WriteLine("this is demo of @namespace");

            }
        }         
       
    }
}

namespace n1
{
    public class demo
    {

        public void show()
        {

            Console.WriteLine("this is demo of n1");

            }
    }
    namespace n2
    {
        class demo
        {

            public void show()
            {

                Console.WriteLine("this is demo of n2");

            }
        }


    }


}
