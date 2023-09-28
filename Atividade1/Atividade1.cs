using System;

int x, y;


do
{
    string[] valores = Console.ReadLine().Split(' ');
    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);

    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro Quadrante");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo Quadrante");
    }
    else if (x < 0 && y < 0) 
    {
        Console.WriteLine("Terceiro Quadrante");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Quarto Quadrante");
    }
}
while (x != 0 && y != 0);

