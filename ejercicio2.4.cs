string contraseñaCorrecta = "admin123"; string contraseña;
do
{
    Console.WriteLine("Ingrese la contraseña:");
    contraseña = Console.ReadLine();

    if (contraseña != contraseñaCorrecta)
    {
        Console.WriteLine("Contraseña incorrecta");
    }

} while (contraseña != contraseñaCorrecta);

Console.WriteLine("Bienvenido al sistema");