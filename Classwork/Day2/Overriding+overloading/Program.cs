using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {


            //Late Binding
            //declare a reference to the Base CLass
            BaseClass o;
            o = new BaseClass();

            //o.Display2(); //non virtual function
            //o.Display3(); //virtual function

            //Console.WriteLine();

            //o = new DerivedClass();
            //o.Display2(); //non virtual function
            //o.Display3(); //virtual function

            //Console.WriteLine();

            //o = new SubDerivedClass();
            //o.Display2(); //non virtual function
            //o.Display3(); //virtual function
            //Console.WriteLine();

            o = new SubSubDerivedClass();
            o.Display2(); //non virtual function
            o.Display3(); //virtual function

            Console.ReadLine();



        }
    }



    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("Base Display1");
        }

        public void Display2()
        {
            Console.WriteLine("Base Display2");
        }

        public virtual void Display3()
        {
            Console.WriteLine("Base Display3");
        }
    }


    public class DerivedClass : BaseClass
    {

        //overloading the method in the derived class
        public void Display1(string s)
        {
            Console.WriteLine("Derived Display1");
        }

        //hiding the method in the derived class
        public new void Display2()
        {
            Console.WriteLine("Derived Display2");
        }

        //overriding the base class method
        public override void Display3()
        {
            Console.WriteLine("Derived Display3");
        }
    }


    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("SubDerived Display3");
        }
    }

    public class SubSubDerivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("SubSubDerived Display3");
        }
    }

}
