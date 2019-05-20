using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Farmaceutica
    {
        //atributos
        private string nombre;
        private string direccionFiscal;
        private string telefono;
        private string correoElectronico;

        //propiedades
        public string Nombre
        {
            get { return nombre; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length >= 5 && value.Length <= 50)
                    nombre = value;
                else
                    throw new Exception("El nombre debe tener entre 5 y 50 caracteres.");
            }
        }

        public string DireccionFiscal
        {
            get { return direccionFiscal; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length >= 10 && value.Length <= 100)
                    direccionFiscal = value;
                else
                    throw new Exception("La direccion debe tener entre 10 y 100 caracteres.");
            }
        }

        public string Telefono
        {
            get { return telefono; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length == 7)
                    telefono = value;
                else
                    throw new Exception("El telefono debe estar compuesto por 7 caracteres.");
            }
        }

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length >= 7 && value.Length <= 25)
                    correoElectronico = value;
                else
                    throw new Exception("El correo electronico debe tener entre 7 y 25 caracteres.");
            }
        }

        //constructores
        public Farmaceutica() { }

        public Farmaceutica(string _nombre, string _direccionFiscal, string _telefono, string _correoElectronico)
        {
            Nombre = _nombre;
            DireccionFiscal = _direccionFiscal;
            Telefono = _telefono;
            CorreoElectronico = _correoElectronico;
        }
    }
}
