using System;

namespace Ques6
{
    class Ques6
    {
        static void Main(string[] args)


        {
            string opt;
           
            Console.WriteLine("List of Books: ");
            Console.WriteLine("c: IT BOOK");
            Console.WriteLine("m: MATH BOOK");
            Console.WriteLine("h: HISTORY BOOK");
            Console.WriteLine("e: ENGLISH BOOKS");

            label:
                Console.WriteLine("Enter your option:");
                opt = Console.ReadLine();

            switch(opt)
            {
                case "c":
                    Console.WriteLine("IT BOOKS");
                    break;
                
                case "m":
                    Console.WriteLine("MATHE BOOKS");
                    break;
                
                case "h":
                    Console.WriteLine("HISTORY BOOKS");
                    break;

                case "e":
                    Console.WriteLine("ENGLISH BOOKS");
                    break;

                default:
                    Console.WriteLine("RETRY");
                    goto label;
        }
    }
    }
}