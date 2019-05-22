using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EntidadesCompartidas
{
    [Serializable]
    public abstract class Usuario
    {
        //atributos
        private int documento;
        private string user;
        private string password;
        private string nombre;

        //propiedades
        public int Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string User
        {
            get { return user; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length <= 15 && value.Length >= 5)
                    user = value.Trim().ToUpper();
                else
                    throw new Exception("El nombre de usuario del usuario debe tener entre 5 y 15 caracteres.");
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                //control rne regex
                if (Regex.Match(value, @"^([A-Za-z]{5})([0-9]{2})$").Success)
                    password = value;
                else
                    throw new Exception("La password debe estar formada por 5 letras + 2 numeros.");
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length <= 25 && value.Length >= 5)
                    nombre = value;
                else
                    throw new Exception("El nombre del usuario debe tener entre 5 y 25 caracteres.");
            }
        }

        //constructores
        public Usuario() { }

        public Usuario(int _documento, string _user, string _password, string _nombre)
        {
            Documento = _documento;
            User = _user;
            Password = _password;
            Nombre = _nombre;
        }
    }
}
