using System;
namespace Application
{
	public class zad3
	{
		public zad3()
		{
            Console.Write("Podaj rozmiar tablicy: ");
            int rozmiar = int.Parse(Console.ReadLine());

            int[,] tablica = new int[rozmiar, rozmiar];
            int liczba = 1;

            for (int i = 0; i < rozmiar; i++)
            {
                if (i % 2 == 0) // Wiersze parzyste
                {
                    for (int j = 0; j < rozmiar; j++)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
                else // Wiersze nieparzyste
                {
                    for (int j = rozmiar - 1; j >= 0; j--)
                    {
                        tablica[i, j] = liczba;
                        liczba++;
                    }
                }
            }


            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}

