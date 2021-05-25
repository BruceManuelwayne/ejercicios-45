using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio45
{
    class Program
    {
        static void Main(string[] args)
        {
            //45.	Realizar una aplicación que solicite el ingreso de una serie de números de registro y nombres de alumno, hasta que el usuario ingrese el registro “0”.
            //Luego, solicitará el ingreso de un número de registro y presentará (de existir) el nombre asociado, repitiendo hasta que el usuario ingrese “0” como número de registro
            var alumnos = new Dictionary<int,string>();
            bool salir1 = false;
            bool salir2 = false;

            while (!salir1) 
            {
                var alumno = Alumno.IngresarNuevo();
                if (alumnos.ContainsKey(alumno.Codigo)) 
                {
                    Console.WriteLine("ya existe");
                    continue;
                }
                alumnos.Add(alumno.Codigo, alumno.Nombre);
                Console.WriteLine("Presione S para agregar otro o O para frenar");
                var tecla = Console.ReadKey(intercept: true);
                salir1 = tecla.Key == ConsoleKey.O;//

                
            }
            while (!salir2)
            {
                Console.WriteLine("     Busqueda de alumno     ");

                int abuscar = Input.IngresarNumero("Ingrese un numero de registro:");
                if (!alumnos.ContainsKey(abuscar))
                {
                    Console.WriteLine("No existe el alumno, ingrese otro codigo");
                    continue;
                }
                string value;
                if (alumnos.TryGetValue(abuscar, out value))
                {
                    Console.WriteLine($"El nombre del alumno es {value}");
                }
                Console.WriteLine("Presione O para salir o ingrese otro codigo:");
                var tecla = Console.ReadKey(intercept: true);
                salir2 = tecla.Key == ConsoleKey.O;

            }


        }
    }
}
