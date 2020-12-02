using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{


    class Program
    {

        #region Main Function
        static void Main(string[] args)
        {

            //test Cases


            Employee e1 = new Employee();
            Employee e2 = new Employee("rahul");
            Employee e3 = new Employee("rahul",500000);
            Employee e4 = new Employee("",50000,12);
            Employee e5 = new Employee("",50000,12);
            Employee e6 = new Employee("",50000,12);

          
            Console.WriteLine(e1.EmpNumber +" "+ e1.EmpName + " " + e1.DeptNumber);
            Console.WriteLine(e2.EmpNumber);
            Console.WriteLine(e3.EmpNumber);
            Console.WriteLine(e4.EmpNumber);
            Console.WriteLine(e5.EmpNumber);
            Console.WriteLine(e6.EmpNumber);



       


            
            


        }
        #endregion

    }



    class Employee
    {

        #region Data Members
        string Name;
        static int empno = 0; // auto generated
        int  EmpNo;
        decimal Basic;
        public decimal DA, HRA, Gross_Salary;
        short DeptNo;
        #endregion


        #region SetterGetters


        // Name
        public string EmpName
        {
            set
            {
                if (value != null)
                {
                    Name = value;
                }
                else
                {
                    //throw new ArgumentException("value");
<<<<<<< HEAD
                    Console.WriteLine( "Name should not be empty" );
=======
               
>>>>>>> a080c355c3fcbe0a22ea9bb220fcda93e0878c02
                }
            }

            get
            {
                return Name;
            }
        }

        //EmpNo
        // auto increment EmpNo

       //  readonly using private
        public int EmpNumber
        {

           
            get
            {
                return EmpNo;
            }

            // only one get/set can be access given
            //reduce access not increase it 
            //public 
            //protected internal
            //internal / protected 
            // private
        }


        // Basic
        public decimal BasicSalary
        {
            set
            {
                if (  (5000 <= value) && (100000 >= value)   )
                {
                    Basic = value;
                }
            }
            get
            {
                return Basic;
            }

        }

        //Dept
        public short DeptNumber
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
                else
                {
                    Console.WriteLine("u hve enterd wrong dept number");
                }
            }
            get
            {
                return DeptNo;

            }
        }


        #endregion






        #region construc
        public Employee()
        {
            EmpNo  = ++empno;
        }
        public Employee(string Name , decimal Basic , short DeptNo)
        {
            EmpNo = ++empno;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
        public Employee(string Name, decimal Basic)
        {
            EmpNo = ++empno;
            this.Name = Name;
            this.Basic = Basic;
        }
        
        public Employee(string Name)
        {
            EmpNo = ++empno;
            this.Name = Name;

        }

        // u can write all above code like

        #endregion

         
        #region Methods
        public void GetSalary()
        {

            DA =  ((Basic * 40) / 100);
            HRA =  ((Basic * 20) / 100);
            Gross_Salary = Basic + DA + HRA;

            Console.WriteLine("Gross Salary : " + Gross_Salary);

        }
        #endregion


    }

}
