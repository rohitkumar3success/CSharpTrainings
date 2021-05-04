using System;

namespace Qsev
{
    class Program
    {
        static void Main(string[] args)
        { 
            int bnum, exp,pow, i;
            string res;
            Console.Write("Enter any basenumber: ");
            bnum = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Enter exponent: ");
            exp = Convert.ToInt32(Console.ReadLine());
 
            pow = 1;
            i = 1;
            while (i <= exp)
            {
                pow= pow * bnum;
                i++;
            }
            
            Console.WriteLine("Power : "+ pow);   
            Console.WriteLine("Do you want to continue?");
            res = Console.ReadLine();
            while(true)
            {
            if(res == "y" || res == "Y")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Exit");
            } 
            }
            
        }
    }

namespace Qsev
{
    class Program
    {
        static void Main(string[] args)
        { 
            int bnum, exp,pow, i;
            string res;
            Console.Write("Enter any basenumber: ");
            bnum = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("Enter any exponent: ");
            exp = Convert.ToInt32(Console.ReadLine());
 
            pow = 1;
            i = 1;
            while (i <= exp)
            {
                pow = pow * bnum;
                i++;
            }
            
            Console.WriteLine("Power : "+ pow);   
            Console.WriteLine("Do you want to continue?");
            res = Console.ReadLine();
            while(true)
            {
            if(res == "y" || res == "Y")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Quit");
            } 
            }
            
        }
    }

}
}
