using VeiculoTerrestre;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro carro = new Carro();
        carro.SerVeiculoTerrestre();
        carro.ToString();
        Onibus onibus = new Onibus();
        onibus.SerVeiculoTerrestre();
        onibus.ToString();
        Moto moto = new Moto();
        moto.SerVeiculoTerrestre();
        moto.ToString();
    }
}