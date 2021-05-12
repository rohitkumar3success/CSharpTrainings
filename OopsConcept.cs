using System;
using System.Collections.Generic;//allow users to create collections 
using System.Linq;//Provides classes and interfaces that support queries that use Language-Integrated Query 
using System.Text;// Contains classes that represent ASCII and Unicode character encodings
using System.Threading.Tasks;//create tasks and run them in asynchronously

namespace Emp_Sal_Successive
{
    class empsalary
    {
        private double balance = 12000;//salary by default given as per month


        public double sal
        {
            get { return balance; }//get method returns the value of the variable balance
            set { balance = value; }//set method assigns a value to the variable balance
        }
    }
    class fuctions//Employee info and sal details datatype
    {
        empsalary i = new empsalary(); //object created for employee salary
        string name;  //name of the employee
        int account; // account no
        double penalty, dep, total; 

        public void fun1() 
        {
            Console.WriteLine("Enter Name of the Employee :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());//convert a specified value to a 32-bit signed integer
            Console.WriteLine("Enter salary Amount :");
            dep = Convert.ToDouble(Console.ReadLine());
            total = i.sal + dep;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the Employee : " + name);

            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + total);

        }
        public void fun2()
        {
            Console.WriteLine("Enter Employee Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Penalty Amount :");
            penalty = Convert.ToDouble(Console.ReadLine());
            if (penalty <= i.sal)
            {
                total = i.sal - penalty;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Employee Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Penalty Amount balnace is : " + total);
            }
            else
                Console.WriteLine("\n\nAmmount does not Exist.");
        }

    }
    class Program// main function program 
    {
        static void Main(string[] args)
        {
            char agn;
            do
            {
                fuctions k = new fuctions();
                int num;
                Console.WriteLine("------------WELCOME TO SUCCESSIVE SALARY MANAGEMENT SYSTEM------------" +
                                                "Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Penalty cut an Amount.");
                num = Convert.ToInt32(Console.ReadLine());//convert a specified value to a 32-bit signed integer

                switch (num)   // implemented to check all the cases and value of variable is checked
                {
                    case 1:
                        k.fun1();
                        break;
                    case 2:
                        k.fun2();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                agn = Convert.ToChar(Console.ReadLine());

            } while (agn == 'y');

            Console.ReadKey();
        }
    }
}