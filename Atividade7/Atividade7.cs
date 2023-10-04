using System;
using System.Collections.Generic;

class Funcionario
{
    private int id;
    private string nome;
    private double salario;

    public Funcionario(int id, string nome, double salario)
    {
        this.id = id;
        this.nome = nome;
        this.salario = salario;
    }

    public int Id
    {
        get { return id; }
    }

    public string Nome
    {
        get { return nome; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }
}

class Program
{
    static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        Console.Write("Quantos funcionários deseja cadastrar? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nCadastro do funcionário {i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            if (FuncionarioExiste(funcionarios, id))
            {
                Console.WriteLine("Funcionário com este ID já existe. Cadastro abortado.");
                continue;
            }

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: ");
            double salario = double.Parse(Console.ReadLine());

            funcionarios.Add(new Funcionario(id, nome, salario));
        }

        Console.Write("\nDigite o ID do funcionário para aumento de salário: ");
        int idAumento = int.Parse(Console.ReadLine());

        Funcionario funcionarioParaAumento = funcionarios.Find(f => f.Id == idAumento);

        if (funcionarioParaAumento != null)
        {
            Console.Write("Digite a porcentagem de aumento de salário: ");
            double percentualAumento = double.Parse(Console.ReadLine());

            double aumento = (percentualAumento / 100) * funcionarioParaAumento.Salario;
            funcionarioParaAumento.Salario += aumento;

            Console.WriteLine("\nLista de funcionários atualizada:");

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.Nome}, Salário: {funcionario.Salario:C}");
            }
        }
        else
        {
            Console.WriteLine("Funcionário com este ID não encontrado. Operação abortada.");
        }
    }

    static bool FuncionarioExiste(List<Funcionario> funcionarios, int id)
    {
        foreach (var funcionario in funcionarios)
        {
            if (funcionario.Id == id)
            {
                return true;
            }
        }
        return false;
    }
}
