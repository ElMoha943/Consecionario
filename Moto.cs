using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consecionario
{
    class Moto : Vehiculo
    {
        private bool _seguro;
        public Moto(int id, string marca, string modelo, int km, double precio, bool Seguro) : base(id, marca, modelo, km, precio)
        {
            this.Seguro = Seguro;
            this.Precio = precio - 7 * km;
            if (Seguro) this.Precio = this.Precio + 500;
        }

        public bool Seguro { get => _seguro; set => _seguro = value; }
    }
}