using System;

namespace Ques7//Question 7 for calculating power
{
    class Program
    {
        static void Main(string[] args)
        {
        result:
            Console.WriteLine("Enter no:");// Enter the number as per required
            int numb = Convert.ToInt32(Console.ReadLine());//conversion using ToInt32


            int pow = 1;//declaring pow variable 
            int n = numb;//to take number as input
            while (n > 0)
            {
                pow *= numb;//storing value for pow
                n--;
            }
            Console.WriteLine("power of {0} calculated to power {1} is: {2}", numb, numb, pow);

            Console.WriteLine("Enter Y to continue else press any key for exit");
            string choice = Console.ReadLine();

            if (choice == "y" || choice == "Y")//condition to continue or not
            {
                goto result;
            }
        }

    }
}
