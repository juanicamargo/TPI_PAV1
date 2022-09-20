using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TPI.Entidades
{
    public class Usuario
    {
        public string NombreUsu { get; set; }
        public string Pass { get; set; }

        public Usuario(string NombreUsu, string password)
        {
            //NombreUsu = nombreUsu; Si el parametro es igual atributo agrego el this
            this.NombreUsu = NombreUsu;

            Pass = password;

        }
    }
}
