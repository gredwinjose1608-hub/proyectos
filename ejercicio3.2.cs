Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);
int numeroUsuario = 0;
int intentos = 0;

Console.WriteLine("INTENTE ADIVINAR EL NUMERO");

while (numeroUsuario != numeroSecreto)
{
    Console.Write("\nIngrese un numero entre 1 y 100: ");
    numeroUsuario = int.Parse(Console.ReadLine());

    if (numeroUsuario < 1 || numeroUsuario > 100)
    {
        Console.WriteLine("El numero debe estar entre 1 y 100.");
    }
    else
    {
        intentos++;

        if (numeroUsuario < numeroSecreto)
        {
            Console.WriteLine("El numero es MAYOR que " + numeroUsuario + ".");
        }
        else if (numeroUsuario > numeroSecreto)
        {
            Console.WriteLine("El numero es MENOR que " + numeroUsuario + ".");
        }
        else
        {
            Console.WriteLine("¡Felicidades! Adivinaste el numero " + numeroSecreto + ".");
            Console.WriteLine("Numero de intentos: " + intentos);
        }
    }
}


