using System;
using DesafioCelular.Entities;

namespace DesafioCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a marca do seu telefone: ");
            string marca = Console.ReadLine();
            Console.Write("Número do telefone: ");
            long numero = long.Parse(Console.ReadLine());
            Console.Write("Modelo do telefone: ");
            string modelo = Console.ReadLine();
            Console.Write("Quantidade de memória em GB (64 ou 128): ");
            int memoria = int.Parse(Console.ReadLine());
            Console.Write("Qual aplicativo deseja instalar? ");
            string aplicativo = Console.ReadLine();

            bool menu = true;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo de acordo com seu telefone: ");
                Console.WriteLine("1 - Iphone");
                Console.WriteLine("2 - Motorola");
                Console.WriteLine("3 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        Smartphone iphone = new Smartphone(marca, numero, modelo, memoria);
                        iphone.ImprimirDados();
                        iphone.Ligar();
                        iphone.App(new Iphone(), aplicativo);
                        break;
                    case "2":
                        Console.Clear();
                        Smartphone motorola = new Smartphone(marca, numero, modelo, memoria);
                        motorola.ImprimirDados();
                        motorola.ReceberLigacoes();
                        motorola.App(new Motorola(), aplicativo);
                        break;
                    case "3":
                        menu = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            Console.WriteLine("Programa encerrado!");
        }
    }
}
