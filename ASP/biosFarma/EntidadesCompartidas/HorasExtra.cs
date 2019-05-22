using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class HorasExtra
    {
        //atributos
        private int minutos;

        //propiedades
        public int Minutos
        {
            get { return minutos; }
            set { minutos = value; }
        }

        //constructores
        public HorasExtra() { }

        public HorasExtra(int _minutos)
        {
            Minutos = _minutos;
        }
    }
}
