using ConsoleApp1;

namespace Main
{
    class App
    {
        public static void Main(string[]args)
        {
            Avion avion=new("Aeroplano");
            Coche coche=new Coche("PickUp");
            Barco barco=new Barco("Lancha");

            avion.ArrancarMotor();
            coche.ArrancarMotor();
            barco.ArrancarMotor();

            avion.Conducir();
            coche.Conducir();
            barco.Conducir();            

            barco.Navegar();
            barco.TipoTerreno("Mar");
            coche.TipoTerreno("Nieve");
            coche.MostrarAviso("tiene un neumatico desinflado");
            coche.MostrarAviso("el combustible indica que esta en reserva!!");
            
            avion.PararMotor();
            coche.PararMotor();
            barco.PararMotor();
        }
    }
}