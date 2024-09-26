// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Modificar para incorporar las siguientes características:    
// Indicar el numero de intentos que le quedan
// Indicar si el número a adivinar es mayor o menor que el introducido


// Pedir al usuario que ingrese un número a adivinar
Console.Write("Introduce un número para que otro jugador lo adivine: ");
int numeroAdivinar = int.Parse(Console.ReadLine());

// Limpiar la consola para que el segundo jugador no vea el número
Console.Clear();
int numIntento = 2;
// Dar tres oportunidades para adivinar el número
for (int i = 0; i < 3; i++)
{
    Console.Write("Adivina el número: ");
    int intento = int.Parse(Console.ReadLine());


    if (intento == numeroAdivinar)
    {
        Console.WriteLine("¡Felicidades! Has adivinado el número.");
        return;
    }
    else
    {
        if (numeroAdivinar < intento)
        {
            Console.WriteLine("El numero " + intento + " es mayor que que el numeroAdivinar.");

        }
        else
        {
            Console.WriteLine("El numero " + intento + " es menor que que el numeroAdivinar.");
        }

        Console.WriteLine("Te quedan " + numIntento + " intentos");
        numIntento--;
        Console.WriteLine("Número incorrecto. Intenta de nuevo.");


    }

}

Console.WriteLine("Lo siento, no has adivinado el número.");
