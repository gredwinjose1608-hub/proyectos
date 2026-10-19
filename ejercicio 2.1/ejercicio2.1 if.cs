Console.WriteLine("Ingrese el dia del mes:");
int dia = int.Parse(Console.ReadLine());


if (dia >= 1 && dia <= 31)
    {
Console.WriteLine("Correcto el dia esta entre 1 y 31.");
    }
else 
{
Console.WriteLine("Error. El dia debe estar entre 1 y 31.");
Console.WriteLine("Ingrese nuevamente el dia del mes por ultima vez si lo hace mal de nuevo tendra que reiniciar:");
dia = int.Parse(Console.ReadLine());   
}


Console.WriteLine("Ingrese el numero del dia de la semana:");
int numeroDia = int.Parse(Console.ReadLine());
string nombreDia = "";

if (numeroDia >= 1 && numeroDia <=7)
    {
    Console.WriteLine("Correcto el numero de dia esta entre 1 y 7.");
    }

else 
{
Console.WriteLine("Error. El  numero de dia debe estar entre 1 y 7.");
Console.WriteLine("Ingrese nuevamente el numero de dia del mes por ultima vez, si lo hace mal de nuevo tendra que reiniciar:");
numeroDia = int.Parse(Console.ReadLine());   
}


if (numeroDia == 1)
    {
        nombreDia = "Lunes";
    }
else if (numeroDia == 2)
    {
        nombreDia = "Martes";
    }
else if (numeroDia == 3)
    {
        nombreDia = "Miercoles";
    }
else if (numeroDia == 4)
    {
        nombreDia = "Jueves";
    }
else if (numeroDia == 5)
    {
        nombreDia = "Viernes";
    }
else if (numeroDia == 6)
    {
        nombreDia = "Sabado";
    }
else
    {
        nombreDia = "Domingo";
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



    if (numeroMes == 1)
    {
        nombreMes = "enero";
    }
    else if (numeroMes == 2)
    {
        nombreMes = "febrero";
    }
    else if (numeroMes == 3)
    {
        nombreMes = "marzo";
    }
    else if (numeroMes == 4)
    {
        nombreMes = "abril";
    }
    else if (numeroMes == 5)
    {
        nombreMes = "mayo";
    }
    else if (numeroMes == 6)
    {
        nombreMes = "junio";
    }
    else if (numeroMes == 7)
    {
        nombreMes = "julio";
    }
    else if (numeroMes == 8)
    {
        nombreMes = "agosto";
    }
    else if (numeroMes == 9)
    {
        nombreMes = "septiembre";
    }
    else if (numeroMes == 10)
    {
        nombreMes = "octubre";
    }
    else if (numeroMes == 11)
    {
        nombreMes = "noviembre";
    }
    else
    {
        nombreMes = "diciembre";
    }

    Console.WriteLine($"Hoy es {nombreDia} {dia} de {nombreMes} de 2026");
