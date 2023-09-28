using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int In = 0;
        int Out = 0;

        for (int i = 0; i < N; i++)
        {
            int X = int.Parse(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                In++;
            }
            else
            {
                Out++;
            }
        }

        Console.WriteLine("Valores dentro do intervalo: " + In);
        Console.WriteLine("Valores fora do intervalo:  " + Out);
    }
}
