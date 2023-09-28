using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome da primeira pessoa: ");
        string pessoa1 = Console.ReadLine();
        Console.Write("Digite o salario primeira pessoa: ");
        double salario1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o nome da segunda pessoa: ");
        string pessoa2 = Console.ReadLine();
        Console.Write("Digite o salario da salario da segunda pessoa: ");
        double salario2 = double.Parse(Console.ReadLine());

        double mediadosalario = (salario1 + salario2) / 2;

        Console.WriteLine($"O salario medio vale: {mediadosalario:C}");
    }
}