using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Coche
    {
        //PROPIEDADES
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private double precio;

        //CONSTRUCTOR
        public Coche(int id, string marca, string modelo, int km, double precio)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Km = km;
            this.Precio = precio;
        }

        //Gets y Sets
        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public double Precio { get => precio; set => precio = value; }

        //Funcion normalizada tostring, para mostrar el contenido del objeto
        public override string ToString()
        {
            return "Marca: "+marca+" Modelo: "+modelo+" Precio: "+precio;
        }
    }
}
