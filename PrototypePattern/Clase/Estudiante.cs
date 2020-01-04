using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern.Clase
{
    public class Estudiante : ICloneable
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string identidad;

        public string Identidad
        {
            get { return identidad; }
            set { identidad = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }


        public object Clone()
        {
            return this.MemberwiseClone();
          //  throw new NotImplementedException();
        }
    }
}
