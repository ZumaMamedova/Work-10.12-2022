// See https://aka.ms/new-console-template for more information
using Degree;

public class Program
{
    public static void Main(string[] args)
    {
        Celsius celsius = new Celsius(30);
        Kelvin kelvin = celsius;
        Console.WriteLine(kelvin.Degree);
    }
}