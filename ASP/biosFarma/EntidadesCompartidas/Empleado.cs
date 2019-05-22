using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Empleado : Usuario
    {
        //atributos
        private string horaInicio;
        private string horaFin;
        private HorasExtra tiempoExtra;

        //propiedades 
        public string HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public string HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }

        public HorasExtra TiempoExtra
        {
            get { return tiempoExtra; }
            set { tiempoExtra = value; }
        }

        //constructores 
        public Empleado() : base() { }

        public Empleado(int _documento, string _user, string _password, string _nombre, string _horaInicio, string _horaFin, HorasExtra _tiempoExtra)
            : base(_documento, _user, _password, _nombre)
        {
            HoraInicio = _horaInicio;
            HoraFin = _horaFin;
            TiempoExtra = _tiempoExtra;
        }
    }
}
