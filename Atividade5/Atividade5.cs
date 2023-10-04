using System;

class Contadobanco
{
    private string nomedotitular;
    private string IDdaconta;
    private double saldo;

    public Contadobanco(string id, string nome)
    {
        IDdaconta = id;
        nomedotitular = nome;
        saldo = 0; 
    }

    public string Id { get; }
    public string Nome { get; }

    public void deposito(double qntd)
    {
        if (qntd > 0)
        {
            saldo += qntd;
            Console.WriteLine($"Depositou ${qntd:f2}. Novo saldo ${saldo:f2}");
        }
        else
        {
            Console.WriteLine("Quantidade inválida. Por favor, digite um número positivo.");
        }
    }

    public void saque(double qntd)
    {
        if (qntd > 0 && qntd <= saldo)
        {
            saldo -= qntd;
            Console.WriteLine($"Sacou ${qntd:f2}. Novo saldo: ${saldo:f2}");
        }
        else if (qntd > saldo)
        {
            Console.WriteLine("Saldo insuficiente para saque");
        }
        else
        {
            Console.WriteLine("Quantidade inválida. Por favor, digite um número positivo.");
        }
    }

    public void mostrarinformacoesdaconta()
    {
        Console.WriteLine($"ID: {IDdaconta}");
        Console.WriteLine($"Titular da conta: {nomedotitular}");
        Console.WriteLine($"Saldo: {saldo:f2}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo a sua conta do banco");
        Console.WriteLine("Digite sua ID:");
        string ID = Console.ReadLine();
        Console.WriteLine("Digite o nome do titular:");
        string nome = Console.ReadLine();
        double qntd;

        Console.Write("Haverá depósito inicial (S/N)?");
        string escolha = Console.ReadLine();
        if (escolha == "S" || escolha == "s")
        {
            Console.WriteLine("Digite a quantidade inicial: $");
            if (!double.TryParse(Console.ReadLine(), out qntd) || qntd <= 0)
            {
                Console.Write("Quantidade inválida. Por favor, digite um número válido.");
                return;
            }
        }
        else
        {
            Console.Write("Obrigado por usar nosso serviço.");
            return;
        }

        Contadobanco contadobanco = new Contadobanco(ID, nome);
        contadobanco.deposito(qntd);

        Console.Write("Digite a quantidade do depósito:");
        if (double.TryParse(Console.ReadLine(), out double qntdsegundodeposito) && qntdsegundodeposito > 0)
        {
            contadobanco.deposito(qntdsegundodeposito);
        }
        else
        {
            Console.Write("Quantidade inválida. Por favor, digite um número válido.");
            return;
        }

        Console.Write("Digite a quantidade para saque: $");
        if (double.TryParse(Console.ReadLine(), out double qntdSaque))
        {
            contadobanco.saque(qntdSaque);
        }
        else
        {
            Console.Write("Quantidade inválida. Por favor, digite um número válido.");
            return;
        }

        contadobanco.mostrarinformacoesdaconta();
        Console.WriteLine("Obrigado por usar nosso serviço.");
    }
}





















    