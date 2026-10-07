Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();

Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

int edadFutura = edad + 14;

Console.WriteLine($"Hola {nombre}, actualmente tienes {edad} años y dentro de 14 años tendrás {edadFutura} años.");
