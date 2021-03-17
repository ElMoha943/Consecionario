using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consecionario
{
    class Auto : Vehiculo
    {
        private bool _airbag;
        private bool _seguro;
        public Auto(int id, string marca, string modelo, int km, double precio, bool Airbag, bool Seguro) : base(id, marca, modelo, km, precio)
        {
            this.Airbag = Airbag;
            this.Seguro = Seguro;
            this.Precio = precio - 10 * km;
            if (Airbag) this.Precio += 200;
            if (Seguro) this.Precio += 1000;
        }
        public bool Airbag { get => _airbag; set => _airbag = value; }
        public bool Seguro { get => _seguro; set => _seguro = value; }
    }
}
//© 2021 GitHub, Inc.