using Actividad_02.Entidades.VentaProductos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actividad_02.Entidades
{
    public class DatosClientes
    {

        public string nombre, apellidoP, apellidoM, correo = null;
        public int telefono = 0; 

        public void Datos()
        {
            Console.Write("Nombre               > ");
            nombre = Console.ReadLine();

            Console.Write("Apellido Paterno     > ");
            apellidoP = Console.ReadLine();

            Console.Write("Apellido Materno     > ");
            apellidoM = Console.ReadLine();


            Console.Write("\nCorreo Electronico   > ");
            correo = Console.ReadLine();

            Console.Write("\nTelefono             > (998)");
            telefono = int.Parse(Console.ReadLine());

            string telefonoA = telefono.ToString();

            if (telefonoA.Length == 7 )
            {
                Console.Clear();
                Cobro cobro = new();
                cobro.Descuento();
            }
            else 
            {
                Console.Beep();
                Console.WriteLine("TIENEN QUE SER 10 NUMEROS DE TELEFONO");
                Console.ReadLine();
                Console.Clear();
                Datos();
            }
        }


        public void ImprimeDatos()
        {
            string Imprime = nombre + " " + apellidoP + " " + apellidoM;

            Console.WriteLine("\n---------------------------------------------");
            Console.WriteLine("\n<            DATOS DEL COMPRADOR            >\n");

            Console.WriteLine("Nombre   > " + Imprime);
            Console.WriteLine("Correo   > " + correo);
            Console.WriteLine("Telefono > " + telefono);
        }
    }
}
