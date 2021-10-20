using System;
using System.Collections.Generic;
using System.Text;

namespace appconsoleherencia2cs
{
    class Persona
    {
        protected string Nombre;
             public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string FechaNacimiento;
            public string fechanacimiento
        {
            get { return FechaNacimiento; }
            set { FechaNacimiento = value; }
        }
        public Persona()
        {
            Nombre = "";
            FechaNacimiento = "";
        }
        public Persona(string Nombre, string FechaNacimiento)
        {
            this.Nombre = Nombre;
            this.FechaNacimiento = FechaNacimiento;
        }
        public override string ToString()
        {
            return "\nNombre :" + Nombre + "\nFecha de nacimiento :" + FechaNacimiento;
        }
        

    }
}
