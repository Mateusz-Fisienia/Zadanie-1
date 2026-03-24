using System;


class Program {
    static void Main() {
       
        Console.WriteLine("Podaj pierwszą liczbę:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Co robimy? (+, -, *, /):");
        string znak = Console.ReadLine();

        Console.WriteLine("Podaj drugą liczbę:");
        double b = double.Parse(Console.ReadLine());

       
        if (znak == "+") {
            Console.WriteLine(a + b);
        }
        else if (znak == "-") {
            Console.WriteLine(a - b);
        }
        else if (znak == "*") {
            Console.WriteLine(a * b);
        }
        else if (znak == "/") {
            Console.WriteLine(a / b);
        }
    }
}