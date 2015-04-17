using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Persona
    {
        String nombre;
        int edad;

        public Persona()
        {

        }

        public Persona(int edad, String nombre)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value;}
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

    }
}
