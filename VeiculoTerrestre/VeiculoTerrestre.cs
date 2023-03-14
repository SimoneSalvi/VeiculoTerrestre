using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeiculoTerrestre
{
    internal class VeiculoTerrestre
    {
        public int Rodas { get; set; }
        public string Cor { get; set; }

        public int Pessoas { get; set; }

        public override string ToString()
        {
            return "Número de rodas: " + Rodas + "\n" + "Cor: " + Cor + "Quantidade de pessoas possível: " + Pessoas;
        }

        public virtual void SerVeiculoTerrestre()
        {
            Console.WriteLine("Olá sou um veículo terrestre!!");
        }

    }
}
