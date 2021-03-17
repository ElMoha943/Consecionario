using Proyecto_Consecionario;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int id, km;
            double precio;
            bool airbag, seguro, modo;
            string tipo, marca, modelo;
            Consecionario CC1 = new Consecionario();
            while (true) {
                Console.WriteLine("1 = AÑADIR COCHES | 0 = QUITAR COCHES");
                if (Convert.ToInt32(Console.ReadLine()) == 1) modo = true;
                else modo = false;
                if (modo == true) {
                    Console.WriteLine("INGRESE EL TIPO");
                    tipo = Console.ReadLine();
                    Console.WriteLine("INGRESE LA MARCA");
                    marca = Console.ReadLine();
                    Console.WriteLine("INGRESE EL MODELO");
                    modelo = Console.ReadLine();
                    Console.WriteLine("INGRESE EL KILOMETRAJE");
                    km = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("INGRESE EL PRECIO");
                    precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("¿TIENE AIRBAG? 1 = SI | 0 = N0");
                    if (Convert.ToInt32(Console.ReadLine()) == 1) airbag = true;
                    else airbag = false;
                    Console.WriteLine("¿TIENE SEGURO? 1 = SI | 0 = NO");
                    if (Convert.ToInt32(Console.ReadLine()) == 1) seguro = true;
                    else seguro = false;
                    CC1.AddCar(tipo, marca, modelo, km, precio, airbag, seguro);
                }
                else
                {
                    Console.WriteLine("INGRESE EL TIPO");
                    tipo = Console.ReadLine();
                    Console.WriteLine("INGRESE EL ID");
                    id = Convert.ToInt32(Console.ReadLine());
                    CC1.RemoveCar(tipo, id);
                }
                CC1.ShowCars("auto");
                CC1.ShowCars("moto");
                CC1.ShowCars("camion");
                Console.WriteLine("¿SALIR? 1 = SI | 0 = NO");
                if (Convert.ToInt32(Console.ReadLine()) == 1) break;
            }
        }
    }
}
