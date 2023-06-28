namespace cwiczenia_6;
class Program
{
    static void Main(string[] args)
    {
        int[,] tablica = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0) // Wiersze parzyste
            {
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = i * 10 + j + 1;
                }
            }
            else // Wiersze nieparzyste
            {
                for (int j = 0; j < 10; j++)
                {
                    tablica[i, j] = (i + 1) * 10 - j;
                }
            }
        }

        // Wyświetlanie tablicy
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

