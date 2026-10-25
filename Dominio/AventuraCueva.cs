using System;

namespace Dominio
{
    public class AventuraCueva : Aventura
    {
        protected override void MostrarIntroduccion()
        {
            Console.WriteLine("\n=== AVENTURA EN LA CUEVA ===");
            Console.WriteLine("Estás en la entrada de una cueva oscura. ¿Qué acción deseas realizar?");
            Console.WriteLine("1. Encender antorcha");
            Console.WriteLine("2. Avanzar a ciegas");
            Console.Write("Elige una opción (1 o 2): ");
        }

        protected override void EjecutarAccion(string opcion)
        {
            Console.WriteLine();
            if (opcion == "1")
            {
                Console.WriteLine("Acción: Encender antorcha.");
                Console.WriteLine("Resultado: Ilumina el camino y revela un tesoro escondido.");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Acción: Avanzar a ciegas.");
                Console.WriteLine("Resultado: El jugador tropieza y cae en un pozo profundo.");
            }
        }
    }
}
