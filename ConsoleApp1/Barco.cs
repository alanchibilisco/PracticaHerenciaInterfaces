namespace ConsoleApp1;

public class Barco : Vehiculo, IInterface, ITipoTerreno
{
    public Barco(string Tipo):base(Tipo){}

    public override void Conducir()
    {
        System.Console.WriteLine($"{Tipo}: navegando!!");
    }

    public void Navegar(){
        System.Console.WriteLine($"{Tipo}, estamos navegando");
    }

    public void TipoTerreno(string terreno)
    {
        System.Console.WriteLine($"Estamos navegando en un {terreno}");
    }
}
