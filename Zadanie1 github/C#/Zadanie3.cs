using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę ocen: ");
        int liczbaOcen = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= liczbaOcen; i++)
        {
            Console.Write($"Podaj ocenę {i}: ");
            double ocena = double.Parse(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / liczbaOcen;

        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zdał.");
        }
        else
        {
            Console.WriteLine("Uczeń nie zdał.");
        }
    }
}