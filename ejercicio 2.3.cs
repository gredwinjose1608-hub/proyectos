Console.WriteLine("Ingrese un numero:");
int numero = int.Parse(Console.ReadLine());

for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
}