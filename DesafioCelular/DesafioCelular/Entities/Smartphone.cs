using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioCelular.Entities
{
    class Smartphone
    {
        public string Modelo { get; set; }
        public long Numero { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string modelo, long numero, int memoria)
        {
            Modelo = modelo;
            Numero = numero;
            Memoria = memoria;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Modelo: " + Modelo.ToUpper() + "\n"
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
