using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SYSLAB
{
    public class Sesion
    {
        public bool Iniciada;
        public string Tipo;
        public string _USUARIO;
        public string _NOMBRE;
        public string _APELLIDO;

        public Sesion(bool inic, string tipo, string usuario, string nombre, string apellido)
        {
            Tipo = tipo;
            Iniciada = inic;
            _USUARIO = usuario;
            _NOMBRE = nombre;
            _APELLIDO = apellido;
        }
    }
}
