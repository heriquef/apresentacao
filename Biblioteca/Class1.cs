using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }

    public class SistemaBiblioteca
    {
        static List<Livro> livros = new List<Livro>();

        public static void Executar()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU BIBLIOTECA ===");
                Console.WriteLine("1. Adicionar livro");
                Console.WriteLine("2. Listar livros");
                Console.WriteLine("0. Voltar");
                Console.Write("Escolha uma opção: ");

                string? entrada = Console.ReadLine();
                int.TryParse(entrada, out opcao);

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o título: ");
                        string? titulo = Console.ReadLine();

                        Console.Write("Digite o autor: ");
                        string? autor = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(titulo) && !string.IsNullOrWhiteSpace(autor))
                        {
                            livros.Add(new Livro { Titulo = titulo, Autor = autor });
                            Console.WriteLine("Livro adicionado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Título ou autor inválido.");
                        }

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("=== Lista de livros ===");
                        if (livros.Count == 0)
                        {
                            Console.WriteLine("Nenhum livro cadastrado.");
                        }
                        else
                        {
                            foreach (var livro in livros)
                            {
                                Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}");
                            }
                        }
                        Console.ReadKey();
                        break;
                }

            } while (opcao != 0);
        }
    }
}
