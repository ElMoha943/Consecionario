using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Consecionario
    {
        //Arrenglo (_coches) de objetos (Coche)
        private Coche[] _coches;
        private int _limite;

        private int _numCocches;

        //Constructor de un consecionario con un limite de coches;
        public Consecionario(int limite)
        {
            this._coches = new Coche[limite];
            _limite = limite;
            _numCocches = 0;
        }

        //METODOS
        public void AddCar(Coche c)
        {
            if (c != null && _numCocches < _coches.Length) {
                _coches[_numCocches] = c;
                _numCocches++;
            }
        }
        public void RemoveCar(Coche c)
        {
            int auxi=-1;
            if (c!=null && _numCocches !=0) {
                for (int i = 0; i < _numCocches; i++)
                {
                    if (c.Id == _coches[i].Id) //COMPARA EL ID DADO POR EL USUARIO CON LOS IDS DE LOS COCHES EN LA LISTA
                    { 
                        auxi = i;
                    }
                }
                if (auxi == -1) {
                    Console.WriteLine("El coche no existe");
                }
                else
                {
                    _coches[auxi] = null; //BORRA LA ENTRY
                    for (int i = auxi; i < _numCocches; i++)
                    {
                        _coches[i] = _coches[i + 1]; //MUEVE TODAS LAS ENTRYS UNA POSICION ATRAS
                    }
                    _numCocches--;
                }
            }
        }
        public void ClearCars()
        {
            this._coches = new Coche[_limite];
            _numCocches = 0;
        }
        public void ShowCars()
        {
            int i;
            for (i = 0; i < _numCocches; i++) {
                Console.WriteLine(_coches[i].ToString());
            }
        }
    }
}
