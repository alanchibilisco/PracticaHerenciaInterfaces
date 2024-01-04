namespace ConsoleApp1;

public class Coche:Vehiculo, ITipoTerreno, IAvisos
{
    #region Constructor
    public Coche(string Tipo):base(Tipo){}        
    #endregion

    #region Functions
    public override void Conducir()
    {
        System.Console.WriteLine($"{Tipo}: conduciendo");
    }
    //metodo implementado heredado de la interfaz
    public void TipoTerreno(string terreno){
        System.Console.WriteLine($"{Tipo}: conduciendo por {terreno}");
    } 
    //metdod implementado de IAvisos
    public void MostrarAviso(string aviso){
        System.Console.WriteLine($"{Tipo}: Tiene un nuevo aviso--> {aviso.ToUpper()}: {GetFecha()}");
    }
    public string GetFecha(){
        
        return DateTime.Now.ToString();
    }
    #endregion
}
