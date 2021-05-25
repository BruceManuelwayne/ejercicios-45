using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio45
{
    public static class Input
    {
        public static string IngresarCadena(string texto, int largoMin, int largoMax) 
        {
            while (true)
            {
                Console.WriteLine(texto);
                string ingreso = Console.ReadLine();

                if (ingreso.Length < largoMin || ingreso.Length > largoMax)
                {
                    Console.WriteLine($"Debe ingresar un nombre entre {largoMin} y {largoMax} caracteres");
                    continue;
                }
                return ingreso;
            }
           
        }
        public static int IngresarNumero(string texto) 
        {
            int numero; 
            while (true) 
            {
                Console.WriteLine(texto);
                string ingreso = Console.ReadLine();
                if (!int.TryParse(ingreso, out numero)) 
                {
                    Console.WriteLine("Codigo de alumno debe ser un numero, intente de nuevo");
                    continue; 
                }
                break; 
            }
            return numero; 
        }

        public static int IngresarCodigoAlumno()
        {
            int codigo;
            while (true)
            {
                codigo = Input.IngresarNumero("Ingrese un codigo de alumno ");
                break; 
             
            }
            return codigo; 
         
            
         
        }
    }
}
