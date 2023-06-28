using System;
namespace cwiczenia_6
{
	public class zad2
	{
		public zad2()
		{
            int[,] tablica = new int[10, 10];
            int liczba = 1;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0) // Wiersze parzyste
                {
                    for (int j = 0; j < 10; j++)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
                else // Wiersze nieparzyste
                {
                    for (int j = 9; j >= 0; j--)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

