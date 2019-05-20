using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Encargado : Usuario
    {
        //atributos
        private string telefono;

        //propiedades
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        //constructores
        public Encargado() : base() { }

        public Encargado(int _documento, string _user, string _password, string _nombre, string _telefono)
            : base(_documento, _user, _password, _nombre)
        {
            Telefono = _telefono;
        }
    }
}
