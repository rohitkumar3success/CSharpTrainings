using System;

namespace EnumTask
{
    class Program
    {
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };
        static void Main(string[] args)
        {
            Console.WriteLine("The {0}th month of the year is {1}", (int)Months.August, Months.August);
        }
    }
}