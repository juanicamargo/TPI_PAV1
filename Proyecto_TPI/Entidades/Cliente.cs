using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_TPI.Entidades
{
    public class Cliente
    {
        private string NroCLiente;
        private string Nombre;
        private string NroCalle;
        private string Calle;
        private int Barrio;
        private int Localidad;

        public Cliente() { }

        public Cliente(string nroCliente, string nombre, string nroCalle, string calle, int barrio, int localidad)
        {
            NroCLiente = nroCliente;
            Nombre = nombre;
            NroCalle = nroCalle;
            Calle = calle;
            Barrio = barrio;
            Localidad = localidad;
        }
        public Cliente(string nroCliente, string nombre)
        {
            NroCLiente = nroCliente;
            Nombre = nombre;
        }

    

    public string NumeroCliente
        {
            get => NroCLiente;
            set => NroCLiente = value;
        }

        public string NombreCliente
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string nroCalle
        {
            get => NroCalle;
            set => NroCalle = value;
        }

        public string calle
        {
            get => Calle;
            set => Calle = value;
        }
        public int barrio
        {
            get => Barrio;
            set => Barrio = value;
        }

        public int localidad
        {
            get => Localidad;
            set => Localidad = value;
        }

    }
}
