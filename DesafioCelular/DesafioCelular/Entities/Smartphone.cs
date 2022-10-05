using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCelular.Entities
{
    class Smartphone
    {
        public string Marca { get; set; }
        public long Numero { get; set; }
        public string Modelo { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string marca, long numero, string modelo, int memoria)
        {
            Marca = marca;
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Marca: " + Marca + "\n"
                + "Modelo: " + Modelo + "\n"
                + "Número: " + Numero + "\n"
                + "Memória em GB: " + Memoria);
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacoes()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void App(IAplicativos _aplicativos, string nomeApp)
        {
            _aplicativos.InstalarAplicativos(nomeApp);
        }
    }
}
