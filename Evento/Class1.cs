using System;
using System.Collections.Generic;

namespace Evento
{
    public class Participante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }

    public class SistemaEvento
    {
        static Dictionary<string, Participante> inscritos = new Dictionary<string, Participante>();

        public static void Executar()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== CONTROLE DE EVENTO ===");
                Console.WriteLine("1. Adicionar participante");
                Console.WriteLine("2. Listar participantes");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha uma opção: ");

                string? entrada = Console.ReadLine();
                int.TryParse(entrada, out opcao);

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o CPF: ");
                        string? cpf = Console.ReadLine();
                        if (cpf == null || inscritos.ContainsKey(cpf))
                        {
                            Console.WriteLine("CPF inválido ou já existente.");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Digite o nome: ");
                        string? nome = Console.ReadLine();

                        Console.Write("Digite o e-mail: ");
                        string? email = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(email))
                        {
                            inscritos[cpf] = new Participante { Nome = nome, Email = email };
                            Console.WriteLine("Participante adicionado!");
                        }
                        else
                        {
                            Console.WriteLine("Nome ou e-mail inválido.");
                        }

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("=== Lista de Participantes ===");
                        if (inscritos.Count == 0)
                        {
                            Console.WriteLine("Nenhum participante cadastrado.");
                        }
                        else
                        {
                            foreach (var p in inscritos)
                            {
                                Console.WriteLine($"CPF: {p.Key}, Nome: {p.Value.Nome}, Email: {p.Value.Email}");
                            }
                        }
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }
    }
}
