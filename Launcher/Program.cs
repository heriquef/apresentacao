using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Escolha um sistema:");
            Console.WriteLine("1 - Biblioteca");
            Console.WriteLine("2 - Evento");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Biblioteca.SistemaBiblioteca.Executar();
                    break;
                case "2":
                    Evento.SistemaEvento.Executar();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
