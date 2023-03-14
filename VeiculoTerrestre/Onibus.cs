using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoTerrestre
{
    internal class Onibus : VeiculoTerrestre
    {
        public int Portas { get; set; }

        public override string ToString()
        {
            return "Número de rodas: " + Rodas + "\n" + "Cor: " + Cor + "Quantidade de pessoas possível: " + Pessoas + "Quantidade de portas: " + Portas;
        }

        public override void SerVeiculoTerrestre()
        {
            Console.WriteLine("Olá sou um onibus!!!!");
        }
    }
}
