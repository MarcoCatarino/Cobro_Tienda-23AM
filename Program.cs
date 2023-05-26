using Actividad_02.Entidades;
using System;

namespace Actividad_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DatosClientes datosClientes = new();
            datosClientes.Datos();

            datosClientes.ImprimeDatos();

            Console.ReadLine();
            Console.Clear();
        }
    }
}
