using System;

namespace Dominio
{
    public class AventuraRio : Aventura
    {
        protected override void MostrarIntroduccion()
        {
            Console.WriteLine("\n=== AVENTURA EN EL RÍO ===");
            Console.WriteLine("Te encuentras frente a un río caudaloso. ¿Qué acción deseas realizar?");
            Console.WriteLine("1. Construir una balsa");
            Console.WriteLine("2. Intentar nadar");
            Console.Write("Elige una opción (1 o 2): ");
        }

        protected override void EjecutarAccion(string opcion)
        {
            Console.WriteLine();
            if (opcion == "1")
            {
                Console.WriteLine("Acción: Construir una balsa.");
                Console.WriteLine("Resultado: Permite cruzar con éxito a la otra orilla.");
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Acción: Intentar nadar.");
                Console.WriteLine("Resultado: La corriente arrastra al jugador y apenas logra salir con vida.");
            }
        }
    }
}
