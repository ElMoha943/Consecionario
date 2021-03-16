using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Creamos un nuevo objeto de clase Coche, con sus propeidades.
            Coche c1 = new Coche(1, "Audi", "4", 100, 5000);
            Coche c2 = new Coche(2, "Ferrari", "2", 85, 6000);
            Coche c3 = new Coche(3, "Audi", "2", 140, 7000);
            Coche c4 = new Coche(4, "Corsa", "6", 10, 15000);
            Coche c5 = new Coche(5, "BMW", "6", 10, 15000);

            Consecionario Consecionario = new Consecionario(10);
            Consecionario.AddCar(c1);
            Consecionario.AddCar(c2);
            Consecionario.AddCar(c3);
            Consecionario.AddCar(c4);
            Consecionario.AddCar(c5);

            Console.WriteLine("TODOS LOS COCHES");
            Consecionario.ShowCars();
            Console.WriteLine("ELIMINO COCHE 2");
            Consecionario.RemoveCar(c2);
            Consecionario.ShowCars();
            Console.WriteLine("BORRO TODOS LOS COCHES Y AÑADO EL 4");
            Consecionario.ClearCars();
            Consecionario.AddCar(c4);
            Consecionario.ShowCars();


            ////Mostramos algunas de sus propiedades
            //Console.WriteLine(c.Precio);
            //Console.WriteLine(c.Marca);

            ////Cambiamos el valor de una de sus propiedades y la mostramos para verificar el cambio.
            //c.Precio = 10000;
            //Console.WriteLine(c.Precio);
            ////Llamamos a la funcion normalizada "ToString" para ver el contenido del objeto.
            //Console.WriteLine(c.ToString());

            //getch() - para evitar que se pare/cierre la consola
            Console.ReadLine();

        }
    }
}
