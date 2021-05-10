using System;
using System.IO;


namespace FilehandlingTask//File handling task
{
	class Program
	{
		static void Main()
		{
			string fName = @"filehandlingtask.txt";// file creation
			string[] ArrAYLine;
			int p, q, r, temp = 1;

	Console.Write("\n\n Getting last n number of lines  :\n");
	Console.Write("--------------\n");

		if (File.Exists(fName))
			{
				File.Delete(fName);
			}
	Console.Write(" Input number of lines to write  :");
			p = Convert.ToInt32(Console.ReadLine());
			ArrAYLine = new string[p];
	Console.Write(" Input {0} strings below :\n", p);
			for (q = 0; q < p; q++)
			{
				Console.Write(" Input line {0} : ", q + 1);
				ArrAYLine[q] = Console.ReadLine();
			}
			System.IO.File.WriteAllLines(fName, ArrAYLine);

	Console.Write("\n No of lines u want to show  :");
			r = Convert.ToInt32(Console.ReadLine());
			temp = r;
		if (r >= 1 && r <= p)
			{
	Console.Write("\n The text of the last {0} lines of the file {1} is : \n", r, fName);
		if (File.Exists(fName))
				{
					for (q = p - r; q < p; q++)
					{
						string[] lines = File.ReadAllLines(fName);
	Console.Write(" The last no {0} line is : {1} \n", temp, lines[q]);
						temp--;
					}
				}
			}
			else
			{
	Console.WriteLine(" Please input the correct line no.");
			}

			Console.WriteLine();
		}
	}
}
