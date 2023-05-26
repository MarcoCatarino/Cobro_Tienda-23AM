using Actividad_02.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_02.Entidades.VentaProductos
{
    public class Cobro : Productos
    {
        DatosClientes datos = new();

        public void Descuento()
        {
            float precioTemporal = 0;
            float precioTotal = 0;

            Consulta_Precios();

            Console.Clear();

            if (precioCombinado >= 1 && precioCombinado <= 4999)
            {
                Console.WriteLine("El precio total de tus compras son: $" + precioCombinado);

            }
            else if (precioCombinado >= 5000 && precioCombinado <=7999)
            {
                Console.WriteLine("El precio total de tus compras es: $" + precioCombinado);

                precioTemporal = precioCombinado * 100 / 10;
                precioTotal = precioTemporal - precioCombinado;

                Console.WriteLine("\n-------------   10% DESCUENTO   -------------");
                Console.WriteLine("\nEl precio con descuento incluido es: $" + precioTotal);


            }
            else if (precioCombinado >= 8000 && precioCombinado <= 9999)
            {
                Console.WriteLine("----------  3 MESES SIN INTERESES  ----------");
                Console.WriteLine("\nEl precio con descuento incluido es: $" + precioCombinado);


            }
            else if (precioCombinado >= 10000)
            {
                Console.WriteLine("--------  6 a 12 MESES SIN INTERESES  --------");
                Console.WriteLine("\nEl precio con descuento incluido es: $" + precioCombinado);


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("<     OPCION INVALIDA     >");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadLine();
                Console.Clear();
                Consulta_Precios();
            }
        }
    }
}
