using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consecionario
{
    class Vehiculo
    {
        //PROPIEDADES
        private int id;
        private string marca;
        private string modelo;
        private int km;
        private double precio;

        //CONSTRUCTOR
        public Vehiculo(int id, string marca, string modelo, int km, double precio)
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.km = km;
            this.precio = precio;
        }

        //Gets y Sets
        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Km { get => km; set => km = value; }
        public virtual double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return "Marca: " + marca + " Modelo: " + modelo + " Precio: " + precio;
        }
    }
}