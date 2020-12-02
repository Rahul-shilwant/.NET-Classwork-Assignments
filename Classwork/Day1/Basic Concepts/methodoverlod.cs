using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassConcepts
{

    class methodoverlod
    {

           static void Main()
        {

            A a = new A();


            // position parameter

            Console.WriteLine("addition of abcd");
            Console.WriteLine("addition of a+b+c+d :" + a.add(10,20,30,40));
            Console.WriteLine("addition of a+b+c :" + a.add(10,20,30) );
            Console.WriteLine(" addition of a+b :" +a.add(10,20));
    
            Console.WriteLine();


            //named parameer
            Console.WriteLine();


            Console.WriteLine(a.add2(a:40));
            Console.WriteLine( a.add2(b:30));
            Console.WriteLine(a.add2(c:20));
            Console.WriteLine( a.add2(a:10,b:20,c:110,d:10));


            Console.WriteLine();





        }



    }
    class A
    {
         
        public int  add(int a , int b, int c, int d)
        {
            return a+b+c+d;
        }
        
        public int add(int a , int b , int c )
        {
            return a + b + c;
           
        }

        public int add(int a , int b )
        {
            return a + b;
           
        }



        public int add2(int a = 0, int b = 0, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }



    }
}
