using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Miguel Peralta", "6624042391", "Hermosillo, Sonora", "maikperalta248@gmail.com", false);
            Console.WriteLine(cliente.Informacion);
        }

        public struct Cliente
        {
            public Cliente(string nombre, string telefono, string direccion, string email, bool es_nuevo)
            {
                Nombre = nombre;
                Telefono = telefono;
                Direccion = direccion;
                Email = email;
                Es_nuevo = es_nuevo;
                Informacion = "El cliente " + nombre + " tiene el número de teléfono " + telefono + 
                    ", vive en " + direccion + " y su email es " + email + ". Su estado de cliente nuevo es " 
                    + es_nuevo + ".";
            }

            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string Email { get; set; }   
            public bool Es_nuevo { get; set; }
            public string Informacion { get; set; }
        }
    }
}
