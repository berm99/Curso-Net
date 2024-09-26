using System;

namespace HolaMundoProyecto
{
    internal class Program
    {
        // Version 1.0
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hola Mundo!!!!");
            Console.WriteLine("Bienvenidos a .Net !!!!!");

            Console.WriteLine("Ingresa tu nombre:");
            string nombre = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Ingresa tu edad:");
            string edadPersonaConsola = Console.ReadLine();

            // Convertir string a entero con Convert
            //                Convierte (Convert) a entero (ToInt32)
            //                lo que has pedido por pantalla (edadPersonaConsola)
            int edadPersona = Convert.ToInt32(edadPersonaConsola);

            //    int          int 
            if (edadPersona >= 18)
            {
                Console.WriteLine("Eres mayor de edad");
            } // Fin del if
            else
            {
                Console.WriteLine("Eres menor de edad");
            } // Fin del else
            */
            /*Console.WriteLine("Ingresa tu edad");
            string edad = Console.ReadLine(); // devuelve string
            int edadPersona = Convert.ToInt32(edad);
            if (edadPersona < 12) {
                Console.WriteLine("Eres un niño/a");
            }
            else if (edadPersona >= 12 && edadPersona < 18) {
                Console.WriteLine("Eres adolescente.");
            }
            else if (edadPersona >= 18 && edadPersona<65) {
                Console.WriteLine("Eres adulto");

            }
            else
            {
                Console.WriteLine("Eres Adulto mayor");
            }
            */
            int numSecreto = 7;
            int adivinanza = -2;
            do
            {
                Console.WriteLine("Adivine el numero secreto: ");
                string adivinanzaNew = Console.ReadLine();
                adivinanza = Convert.ToInt32(adivinanzaNew);
                if (adivinanza != numSecreto) {
                    Console.WriteLine("Error, Inténtelo de nuevo");
                }
            } while (adivinanza != numSecreto);
            Console.WriteLine("Felicidades, adivinaste el número secreto!");
        } // Fin del método Main
    } // Fin de la clase Program
} // namespace HolaMundoProyecto

/*
 * ORDEN 
1-Solucion (unica)
2-Proyecto (varios)
3-namespace (varios)
4-class (varios)
5-codigo (metodo) (varios)
 * 
 */
//expresion: es lo que esta dentro de las comillas
// si pongo /fix y program.cs en chat github copilot te arregla el codigo
// string nombre = console.readline() ?? string.Empty; 
//la linea de arriba queire decir que si da error que te deje vacia la variable 

;

