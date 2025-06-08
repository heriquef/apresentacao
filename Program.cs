using System;
using System.Collections.Generic;

class Participante
{
    public string Nome { get; set; }
    public string Email { get; set; }
}

class Program
{
    static Dictionary<string, Participante> inscritos = new Dictionary<string, Participante>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== CONTROLE DE EVENTO ===");
            Console.WriteLine("1. Adicionar participante");
            Console.WriteLine("2. Listar participantes");
            Console.WriteLine("3. Buscar participante por CPF");
            Console.WriteLine("4. Remover participante");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Adicionar(); break;
                case 2: Listar(); break;
                case 3: Buscar(); break;
                case 4: Remover(); break;
                case 0: Console.WriteLine("Encerrando programa..."); break;
                default: Console.WriteLine("Opção inválida."); break;
            }

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();

        } while (opcao != 0);
    }

    static void Adicionar()
    {
        Console.Write("Digite o CPF do participante: ");
        string cpf = Console.ReadLine();

        if (inscritos.ContainsKey(cpf))
        {
            Console.WriteLine("Já existe um participante com esse CPF.");
            return;
        }

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o e-mail: ");
        string email = Console.ReadLine();

        inscritos.Add(cpf, new Participante { Nome = nome, Email = email });
        Console.WriteLine("Participante adicionado com sucesso.");
    }

    static void Listar()
    {
        if (inscritos.Count == 0)
        {
            Console.WriteLine("Nenhum participante inscrito.");
            return;
        }

        Console.WriteLine("== Lista de Participantes ==");
        foreach (var item in inscritos)
        {
            Console.WriteLine($"CPF: {item.Key} | Nome: {item.Value.Nome} | Email: {item.Value.Email}");
        }
    }

    static void Buscar()
    {
        Console.Write("Digite o CPF para buscar: ");
        string cpf = Console.ReadLine();

        if (inscritos.TryGetValue(cpf, out Participante p))
        {
            Console.WriteLine($"Nome: {p.Nome} | Email: {p.Email}");
        }
        else
        {
            Console.WriteLine("Participante não encontrado.");
        }
    }

    static void Remover()
    {
        Console.Write("Digite o CPF para remover: ");
        string cpf = Console.ReadLine();

        if (inscritos.Remove(cpf))
        {
            Console.WriteLine("Participante removido com sucesso.");
        }
        else
        {
            Console.WriteLine("Participante não encontrado.");
        }
    }
}
