using System;

namespace Dominio
{
    // Clase abstracta que implementa el patrón Template Method
    public abstract class Aventura
    {
        // MÉTODO PLANTILLA (Template Method): Define el esqueleto del flujo general
        public void EjecutarFlujoAventura(Func<string?> solicitarEleccionJugador)
        {
            MostrarIntroduccion();

            string? opcion = solicitarEleccionJugador();

            if (ValidarEleccion(opcion))
            {
                EjecutarAccion(opcion!);
                MostrarDesenlaceComun();
            }
            else
            {
                Console.WriteLine("\n[!] Opción no válida. El jugador dudó demasiado y la aventura no pudo continuar.");
            }
        }

        // Paso 1: Mostrar introducción (específico de cada aventura)
        protected abstract void MostrarIntroduccion();

        // Paso 2: Validar la elección del jugador (común para todas las aventuras)
        protected virtual bool ValidarEleccion(string? opcion)
        {
            return opcion == "1" || opcion == "2";
        }

        // Paso 3: Ejecutar la acción elegida (específico de cada aventura)
        protected abstract void EjecutarAccion(string opcion);

        // Paso 4: Mostrar un desenlace común (común para todas las aventuras)
        protected void MostrarDesenlaceComun()
        {
            Console.WriteLine("\n--- Desenlace común: La jornada ha terminado y el aventurero descansa para su próxima misión. ---\n");
        }
    }
}
