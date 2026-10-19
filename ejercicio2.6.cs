int opcion;

do
{
    Console.WriteLine("\n===== MENU PRINCIPAL =====");
    Console.WriteLine("1. Mostrar nombre");
    Console.WriteLine("2. Mostrar edad");
    Console.WriteLine("3. Limpiar pantalla");
    Console.WriteLine("4. Salir");

    Console.Write("Seleccione una opcion: ");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Mi nombre es Gredwdin.");
            break;

        case 2:
            Console.WriteLine("Mi edad es 20 años.");
            break;

        case 3:
            Console.Clear();
            break;

        case 4:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opcion no valida.");
            break;
    }

} while (opcion != 4);

