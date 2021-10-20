using System;
using System.Collections.Generic;
using System.Text;

namespace appconsoleherencia2cs
{
    class Alumno : Persona
    {
        private string Carrera;
            public string carerra
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        private string Matricula;
            public string matricula
        {
            get { return Matricula; }
            set { Matricula = value;}
        }
        public Alumno() : base()
        {
            Carrera = "";
            Matricula = "";
        }
        public Alumno(string Nombre, string FechaNacimiento, string Carerra, string Matricula) : base(Nombre,FechaNacimiento)
        {
            this.carerra = Carerra;
            this.Matricula = Matricula;
        }
        public override string ToString()
        {
            return "\nNombre de alumno : " + Nombre + "\nFecha de Nacimiento : " + FechaNacimiento + "\nCarrera : " + Carrera + "\nMatricula : " + Matricula;
        }
        
    }
}
