using System;
using System.Diagnostics;

//Napisz program, który oblicza pierwiastki równania kwadratowego ax2 + bx + c = 0.
//Zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury przez użytkownika.
//Wszystkie zmienne wyświetl na ekranie z dokładnością do dwóch miejsc po przecinku.

class PierwiastkiRownaniaKwadratowego
{
    static void Main(string[] args)
    {
        Console.WriteLine("obliczanie pierwiastków równania kwadratowego ax2 + bx + c = 0.");
        Console.WriteLine("Podaj wartość dla a: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość dla b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wartość dla c: ");
        double c = double.Parse(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b + sqrtDelta) / (2 * a);
            double x2 = (-b + sqrtDelta) / (2 * a);
            Console.WriteLine($"Równanie ma dwa pierwiastki rzeczywiste: x1 = {Math.Round(x1, 2)}, x2 = {Math.Round(x2, 2)}.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Równanie ma jeden podwójny pierwiastek rzeczywisty: x = {Math.Round(x, 2)}.");
        }
        else
        {
            Console.WriteLine("Równanie nie ma pierwiastków rzeczywistych.");
        }
    }
}