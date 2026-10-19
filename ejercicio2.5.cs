int suma = 0;
int numero;

for (int i = 1; i <= 5; i++)
{
    Console.Write("Numero " + i + ": ");
    numero = int.Parse(Console.ReadLine());

    suma = suma + numero;
}

Console.WriteLine("La suma es: " + suma);
