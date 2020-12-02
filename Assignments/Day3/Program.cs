using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {




        }
    }

    public abstract class Employee
    {


        #region DataMemebers
        string Name;
        static int empno = 0;
        int EmpNo;
        short DeptNo;
        public abstract decimal basic { get;
            set;
        }
        #endregion


        #region Properties(SetterGetters)

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
                    Console.WriteLine("Name should not be empty");
                }
            }
        }

        //EMPNO
        public int EmpNumber
        {
            get
            {
                return EmpNo;
            }
        }

        // DeptNo
        public short Department
        {
            set
            {
                if (value > 0)
                {
                    DeptNo = value;
                }
            }
            get
            {
                return DeptNo;
                }
        }


        #endregion


        #region Construtor

        public Employee(string Name , short DeptNo)
        {
            EmpNo = ++empno;
            this.Name = Name;
            this.DeptNo = DeptNo;

        }

        
        #endregion



        #region Methods

        public abstract decimal CalNetSalary();

        #endregion





    }
    class Manager : Employee
    {
        string Designation;
        public string DesignationName
        {
            set
            {
                if (value != null)
                {
                    Designation = value;
                }
                else
                {
                    Console.WriteLine("invalid Designation");
                }
            }
            get
            {
                return Designation;
            }
        }

        //from base class to access base class constructor properties
        public static string Name { get; }
        public static short DeptNo { get; private set; }
        //public decimal basic { get; }
        public override decimal basic
        {
            set
            {
                if ((value > 5000) && (value < 50000)) 
                {
                    basic = value;
                } }
            get
            {
                return basic;
            }
        
        }



        public Manager(string Designation) : base(Name,DeptNo)
        {
            this.Designation = Designation;
        }

        public override decimal CalNetSalary()
        {
         
            return this.basic;
        }
    }

    class GeneralManager : Manager
    {

        string Perks;
        public string PERKS
        { 
            set
            {
                if (value == null)
                {
                    
                    Console.WriteLine("You are not getting extra bonus");
                }
                else
                {
                    Console.WriteLine("Congratulation u got bonus");
                }
            }
        }


        public static string Designation { get; }

        public GeneralManager(string Perks) : base(Designation)
        {
            this.Perks = Perks;
        }

        public override decimal CalNetSalary()
        {
            return basic;
        }


    }
    class CEO : Employee
    {

        // CEO Name
        public string CEOName
        {
            set
            {
                if (value != null)
                {
                    CEOName = value;
                }
            }
        }



        //from base class for access base class constructor properties
        public static string Name { get; }
        public static short DeptNo { get; private set; }

        public CEO(string CEOName) : base(Name,DeptNo)
        {
            this.CEOName = CEOName;
        }





        public override decimal basic
        {
            set
            {
                if ((value > 50000) && (value < 500000000))
                {
                    basic = value;
                }
            }
            get
            {
                return basic;
            }

        }

        public sealed override decimal CalNetSalary()
        { 
            return this.basic;
        }

    }
}
