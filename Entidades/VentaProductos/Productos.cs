using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_02.Entidades.VentaProductos
{
    public class Productos
    {

       public void Consulta_Precios()
        {
            Console.Write("Cuantos productos se estan comprando? > ");
            int numProductos = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            float[] precioProducto = new float[numProductos];

            for (int i = 0; i < numProductos; i++) 
            {
                Console.Write("Precio prodcuto > $");
                precioProducto[i] = float.Parse(Console.ReadLine());
            }
            
            foreach (float precioProductos in precioProducto)
            {
                precioCombinado += precioProductos;
            }
        }
        public float precioCombinado = 0;
    }
}


