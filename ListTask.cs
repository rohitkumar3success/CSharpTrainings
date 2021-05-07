using System;
using System.Collections.Generic;//

namespace ListTsk
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<int> toplist = new List<int>();//creating list

            List<string> bottomlist = new List<string>();

            Console.WriteLine("--------------Type of List-----------");
            Console.WriteLine("Type 2 for INTEGER list or type 3 for STRING list");
            int ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)//condition to check for input
            {
                goto stage1;
            }
            else if (ans == 3)
            {
                goto stage2;
            }
            else
            {
                Console.WriteLine("-------------EXIT OF PROGRAM-------------");
            }

        stage1:
            Console.WriteLine("Element to be inserted:");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in the list:");
            for (int i = 0; i < numbers; i++)
            {
                int j = Convert.ToInt32(Console.ReadLine());
                toplist.Add(j);
            }
            Console.WriteLine("Count Is: " + toplist.Count);



        stage2:
            Console.WriteLine("Element to be inserted:");

            int elements = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in the list:");
            for (int i = 0; i < elements; i++)
            {
                string j = Console.ReadLine();
                bottomlist.Add(j);
            }
            Console.WriteLine("Count Is: " + bottomlist.Count);
        }
    }
}