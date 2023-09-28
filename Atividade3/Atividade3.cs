using System;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome da primeira pessoa: ");
        string pessoa1 = Console.ReadLine();
        Console.Write("Digite a idade da primeira pessoa: ");
        int idade1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome da segunda pessoa: ");
        string pessoa2 = Console.ReadLine();
        Console.Write("Digite a idade da segunda pessoa: ");
        int idade2 = int.Parse(Console.ReadLine());

        string pessoamaisvelha = FindOlderPerson(pessoa1, idade1, pessoa2, idade2);

        Console.WriteLine($"A pessoa mais velha e: {pessoamaisvelha}");
    }   

    static string FindOlderPerson(string nomedapessoa1, int idadedapessoa1, string nomedapessoa2, int idadedapessoa2)
    {
        if (idadedapessoa1 > idadedapessoa2)
        {
            return nomedapessoa1;
        }
        else if (idadedapessoa2 > idadedapessoa1)
        {
            return nomedapessoa2;
        }
        else
        {
            return "As duas pessoas tem a mesma idade.";
        }
    }
}