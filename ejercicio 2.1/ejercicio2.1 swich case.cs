Console.WriteLine("Ingrese el dia del mes:");
int dia = int.Parse(Console.ReadLine());

if (dia >= 1 && dia <= 31)
{
    Console.WriteLine("Correcto el dia esta entre 1 y 31.");
}
else
{
    Console.WriteLine("Error. El dia debe estar entre 1 y 31.");
    Console.WriteLine("Ingrese nuevamente el dia del mes por ultima vez, si lo hace mal de nuevo tendra que reiniciar:");
    dia = int.Parse(Console.ReadLine());
}


Console.WriteLine("Ingrese el numero del dia de la semana:");
int numeroDia = int.Parse(Console.ReadLine());
string nombreDia = "";

if (numeroDia >= 1 && numeroDia <= 7)
{
    Console.WriteLine("Correcto el numero de dia esta entre 1 y 7.");
}
else
{
    Console.WriteLine("Error. El numero de dia debe estar entre 1 y 7.");
    Console.WriteLine("Ingrese nuevamente el numero de dia por ultima vez, si lo hace mal de nuevo tendra que reiniciar:");
    numeroDia = int.Parse(Console.ReadLine());
}

switch (numeroDia)
{
    case 1:
        nombreDia = "Lunes";
        break;

    case 2:
        nombreDia = "Martes";
        break;

    case 3:
        nombreDia = "Miercoles";
        break;

    case 4:
        nombreDia = "Jueves";
        break;

    case 5:
        nombreDia = "Viernes";
        break;

    case 6:
        nombreDia = "Sabado";
        break;

    case 7:
        nombreDia = "Domingo";
        break;

    default:
        nombreDia = "Dia incorrecto";
        break;
}


Console.WriteLine("Ingrese el numero del mes:");
int numeroMes = int.Parse(Console.ReadLine());
string nombreMes = "";

if (numeroMes >= 1 && numeroMes <= 12)
{
    Console.WriteLine("Correcto el mes esta entre 1 y 12.");
}
else
{
    Console.WriteLine("Error. El mes debe estar entre 1 y 12.");
    Console.WriteLine("Ingrese nuevamente el mes por ultima vez, si lo hace mal de nuevo tendra que reiniciar:");
    numeroMes = int.Parse(Console.ReadLine());
}

switch (numeroMes)
{
    case 1:
        nombreMes = "enero";
        break;

    case 2:
        nombreMes = "febrero";
        break;

    case 3:
        nombreMes = "marzo";
        break;

    case 4:
        nombreMes = "abril";
        break;

    case 5:
        nombreMes = "mayo";
        break;

    case 6:
        nombreMes = "junio";
        break;

    case 7:
        nombreMes = "julio";
        break;

    case 8:
        nombreMes = "agosto";
        break;

    case 9:
        nombreMes = "septiembre";
        break;

    case 10:
        nombreMes = "octubre";
        break;

    case 11:
        nombreMes = "noviembre";
        break;

    case 12:
        nombreMes = "diciembre";
        break;

    default:
        nombreMes = "mes incorrecto";
        break;
}

if (dia >= 1 && dia <= 31 &&
    numeroDia >= 1 && numeroDia <= 7 &&
    numeroMes >= 1 && numeroMes <= 12)
{
    Console.WriteLine($"Hoy es {nombreDia} {dia} de {nombreMes} de 2026");
}
else
{
    Console.WriteLine("No se puede mostrar la fecha porque hay datos incorrectos.");
}

