using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Medicamento
    {
        //atributos
        private int codigo;
        private Farmaceutica farmaceutica;
        private string nombre;
        private string descripcion;
        private float precio;
        private string tipo;
        private int stock;

        //propiedades
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Farmaceutica Farmaceutica
        {
            get { return farmaceutica; }
            set { farmaceutica = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length >= 3 && value.Length <= 8)
                    nombre = value;
                else
                    throw new Exception("El nombre del medicamento debe tener entre 3 y 8 caracteres.");
            }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length >= 10 && value.Length <= 100)
                    descripcion = value;
                else
                    throw new Exception("La descripcion del medicamento debe tener entre 10 y 100 caracteres.");
            }
        }

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set
            {
                //control cantidad caracteres contra la base de datos
                if (value.Length >= 4 && value.Length <= 13)
                    if (Regex.Match(value.ToUpper(), @"^(DIABETICO|CARDIOLOGICO|OTRO)$").Success)
                        tipo = value;
                    else
                        throw new Exception("El tipo del medicamento debe ser DIABETICO, OTRO o CARDIOLOGICO.");
                else
                    throw new Exception("El tipo del medicamento debe tener entre 4 y 13 caracteres.");
            }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        //constructores
        public Medicamento() { }

        public Medicamento() { }
    }
}
