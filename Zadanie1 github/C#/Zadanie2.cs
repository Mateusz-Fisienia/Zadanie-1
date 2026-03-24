using System;

class Program
{
    static void Main()
    {
        Console.Write("Wybierz jednostkę wejściową (C lub F): ");
        string opcja = Console.ReadLine().ToUpper();

        Console.Write("Podaj wartość temperatury: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (opcja == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C to {wynik:F2}°F");
        }
        else if (opcja == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F to {wynik:F2}°C");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wybór.");
        }
    }
}
