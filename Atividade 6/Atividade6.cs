using System;

class Program
{
    static void Main()
    {
        string[] quartos = new string[10]; 
        Console.WriteLine("Bem-vindo à pensão!");
        Console.Write("Quantos estudantes vão alugar quartos? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nRegistro do estudante {i + 1}:");
            Console.Write("Nome do estudante: ");
            string nome = Console.ReadLine();
            Console.Write("Email do estudante: ");
            string email = Console.ReadLine();

            int quarto;
            do
            {
                Console.Write($"Escolha um quarto (0-9) para {nome}: ");
                quarto = int.Parse(Console.ReadLine());

                if (quarto < 0 || quarto > 9 || quartos[quarto] != null)
                {
                    Console.WriteLine("Quarto inválido ou ocupado. Tente novamente.");
                }
            } while (quarto < 0 || quarto > 9 || quartos[quarto] != null);

            quartos[quarto] = $"{nome} ({email})";
        }

        Console.WriteLine("\nLista de ocupantes dos quartos:");
        for (int i = 0; i < 10; i++)
        {
            if (quartos[i] != null)
            {
                Console.WriteLine($"Quarto {i}: {quartos[i]}");
            }
        }
    }
}
