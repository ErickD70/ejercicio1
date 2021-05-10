using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class lista
    {
        private string Nombre;
       

        public lista()
        {
            Nombre = string.Empty;
           
 
        }

        public lista(string nom)
        {
            Nombre = nom;
            
        }
        public String nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
            



    }
}
