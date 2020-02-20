using System;
using System.Text;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';

		static void Main(string[] args)
		{
            // The solution implementation goes here

            for (int row = 1; row <= 15; row++)
            {

                for (int col = 1; col <= 30; col++)
                {
                    if (row == 1 || row == 15 || col == 1 || col == 30)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;                        
                        Console.Write(block);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(block);
                    }
                }

                Console.WriteLine();
            }
            

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			//Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}
	}
}
