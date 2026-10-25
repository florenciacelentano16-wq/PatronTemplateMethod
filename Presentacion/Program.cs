using System;
using Aplicacion;
using Dominio;

namespace Presentacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gestorAventuras = new GestorAventurasService();

            Console.WriteLine("==========================================");
            Console.WriteLine("   PATRÓN TEMPLATE METHOD: AVENTURAS      ");
            Console.WriteLine("==========================================");
            Console.WriteLine("Seleccione la aventura que desea iniciar:");
            Console.WriteLine("1. Aventura en la Cueva");
            Console.WriteLine("2. Aventura en el Río");
            Console.Write("Su elección (1 o 2): ");

            string? tipoAventura = Console.ReadLine();

            Aventura? aventuraSeleccionada = gestorAventuras.CrearAventura(tipoAventura);

            if (aventuraSeleccionada != null)
            {
                aventuraSeleccionada.EjecutarFlujoAventura(() => Console.ReadLine());
            }
            else
            {
                Console.WriteLine("\n[!] No se seleccionó un tipo de aventura válido.");
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
