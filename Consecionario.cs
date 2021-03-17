using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Consecionario
{
    class Consecionario
    {
        private Auto[] _Autos;
        private Moto[] _Motos;
        private Camion[] _Camiones;
        private int _numautos, _nummotos, _numcamiones;

        public Consecionario()
        {
            this._Autos = new Auto[5];
            this._Motos = new Moto[5];
            this._Camiones = new Camion[5];
            _numautos = 0;
            _nummotos = 0;
            _numcamiones = 0;
        }

        //METODOS
        public void AddCar(string tipo, string marca, string modelo, int km, double precio, bool airbag, bool seguro)
        {
            switch (tipo)
            {
                case "auto":
                    this._Autos[_numautos] = new Auto(_numautos, marca, modelo, km, precio, airbag, seguro);
                    _numautos++;
                    break;

                case "moto":
                    this._Motos[_nummotos] = new Moto(_nummotos, marca, modelo, km, precio, seguro);
                    _nummotos++;
                    break;

                case "camion":
                    this._Camiones[_numcamiones] = new Camion(_numcamiones, marca, modelo, km, precio, seguro);
                    _numcamiones++;
                    break;
            }
        }
        public void RemoveCar(string tipo, int id)
        {
            int auxi = -1;
            switch (tipo)
            {

                case "auto":
                    for (int i = 0; i < _numautos; i++)
                    {
                        if (id == _Autos[i].Id) //COMPARA EL ID DADO POR EL USUARIO CON LOS IDS DE LOS COCHES EN LA LISTA
                        {
                            auxi = i;
                        }
                    }
                    if (auxi == -1)
                    {
                        Console.WriteLine("El coche no existe");
                    }
                    else
                    {
                        _Autos[auxi] = null; //BORRA LA ENTRY
                        for (int i = auxi; i < _numautos; i++)
                        {
                            _Autos[i] = _Autos[i + 1]; //MUEVE TODAS LAS ENTRYS UNA POSICION ATRAS
                        }
                        _numautos--;
                    }
                    break;

                case "moto":
                    for (int i = 0; i < _nummotos; i++)
                    {
                        if (id == _Motos[i].Id) //COMPARA EL ID DADO POR EL USUARIO CON LOS IDS DE LOS COCHES EN LA LISTA
                        {
                            auxi = i;
                        }
                    }
                    if (auxi == -1)
                    {
                        Console.WriteLine("La moto no existe");
                    }
                    else
                    {
                        _Motos[auxi] = null; //BORRA LA ENTRY
                        for (int i = auxi; i < _nummotos; i++)
                        {
                            _Motos[i] = _Motos[i + 1]; //MUEVE TODAS LAS ENTRYS UNA POSICION ATRAS
                        }
                        _nummotos--;
                    }
                    break;

                case "camion":
                    for (int i = 0; i < _numcamiones; i++)
                    {
                        if (id == _Camiones[i].Id) //COMPARA EL ID DADO POR EL USUARIO CON LOS IDS DE LOS COCHES EN LA LISTA
                        {
                            auxi = i;
                        }
                    }
                    if (auxi == -1)
                    {
                        Console.WriteLine("El coche no existe");
                    }
                    else
                    {
                        _Camiones[auxi] = null; //BORRA LA ENTRY
                        for (int i = auxi; i < _numcamiones; i++)
                        {
                            _Camiones[i] = _Camiones[i + 1]; //MUEVE TODAS LAS ENTRYS UNA POSICION ATRAS
                        }
                        _numcamiones--;
                    }
                    break;

                default:

                    break;
        }
    }
        public void ClearCars(string tipo)
        {
            switch (tipo)
            {
                case "auto":
                    this._Autos = new Auto[100];
                    _numautos = 0;
                    break;

                case "moto":
                    this._Motos = new Moto[100];
                    _nummotos = 0;
                    break;

                case "camion":
                    this._Camiones = new Camion[100];
                    _numcamiones = 0;
                    break;

            }
        }
        public void ShowCars(string tipo)
        {
            switch (tipo)
            {
                case "auto":
                    for (int i = 0; i < _numautos; i++)
                    {
                        Console.WriteLine(_Autos[i].ToString());
                    }
                    break;

                case "moto":
                    for (int i = 0; i < _nummotos; i++)
                    {
                        Console.WriteLine(_Motos[i].ToString());
                    }
                    break;

                case "camion":
                    for (int i = 0; i < _numcamiones; i++)
                    {
                        Console.WriteLine(_Camiones[i].ToString());
                    }
                    break;
                default:
                    Console.WriteLine("NADA QUE MOSTRAR");
                    break;

            }
        }
    }
}