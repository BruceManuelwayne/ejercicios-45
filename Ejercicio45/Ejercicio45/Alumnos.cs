using System;

namespace Ejercicio45
{
    internal class Alumno
    {
        private Alumno(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
        public int Codigo { get; }

        public string Nombre { get; }

        internal static Alumno IngresarNuevo()
        {
            int codigo = Input.IngresarNumero("Ingrese el codigo de Alumno");

            string nombre = Input.IngresarCadena("Ingrese el nombre del alumno", 1, 30);

            var alumno = new Alumno(codigo, nombre);

            return alumno;
        }
       
    }
}