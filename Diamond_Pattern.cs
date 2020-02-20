using System;

namespace diamondpattern
{
	class Program
	{
		static void Main(string[] args)
		{
			{
				int i, j, count = 1, number;
				Console.Write("Enter number of rows:");
				number = int.Parse(Console.ReadLine());
				count = number - 1;
				for (j = 1; j <= number; j++)
				{
					for (i = 1; i <= count; i++)
						Console.Write("*");

					for (i = 1; i <= 2 * j - 1; i++)
						Console.Write("#");
					for (i = 1; i <= count; i++)
						Console.Write("*");
					Console.WriteLine();
					count--;
				}
				count = 1;
				for (j = 1; j <= number - 1; j++)
				{
					for (i = 1; i <= count; i++)
						Console.Write("*");
					count++;
						Console.WriteLine();
					}
					Console.ReadLine();
				}
			}
		}
	}
