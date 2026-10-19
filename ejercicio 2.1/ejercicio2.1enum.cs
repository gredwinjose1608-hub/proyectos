Console.WriteLine("Ingrese el dia del mes:");
int dia = int.Parse(Console.ReadLine());

if (dia >= 1 && dia <= 31)
{
    Console.WriteLine("Correcto, el dia esta entre 1 y 31.");
}
else
{
    Console.WriteLine("Error. El dia debe estar entre 1 y 31.");
    Console.WriteLine("Ingrese nuevamente el dia por ultima vez:");
    dia = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ingrese el numero del dia de la semana:");
int numeroDia = int.Parse(Console.ReadLine());

if (numeroDia >= 1 && numeroDia <= 7)
{
    Console.WriteLine("Correcto, el numero del dia esta entre 1 y 7.");
}
else
{
    Console.WriteLine("Error. El dia de la semana debe estar entre 1 y 7.");
    Console.WriteLine("Ingrese nuevamente el dia por ultima vez:");
    numeroDia = int.Parse(Console.ReadLine());
}

Console.WriteLine("Ingrese el numero del mes:");
int numeroMes = int.Parse(Console.ReadLine());

if (numeroMes >= 1 && numeroMes <= 12)
{
    Console.WriteLine("Correcto, el mes esta entre 1 y 12.");
}
else
{
    Console.WriteLine("Error. El mes debe estar entre 1 y 12.");
    Console.WriteLine("Ingrese nuevamente el mes por ultima vez:");
    numeroMes = int.Parse(Console.ReadLine());
}

if (dia >= 1 && dia <= 31 &&
    numeroDia >= 1 && numeroDia <= 7 &&
    numeroMes >= 1 && numeroMes <= 12)
{
    DiasSemana nombreDia = (DiasSemana)numeroDia;
    Meses nombreMes = (Meses)numeroMes;

    Console.WriteLine($"Hoy es {nombreDia} {dia} de {nombreMes.ToString().ToLower()} de 2026");
}
else
{
    Console.WriteLine("Los datos ingresados no son validos. Reinicie el programa.");
}

enum DiasSemana
{
    Lunes = 1,
    Martes = 2,
    Miercoles = 3,
    Jueves = 4,
    Viernes = 5,
    Sabado = 6,
    Domingo = 7
}

enum Meses
{
    Enero = 1,
    Febrero = 2,
    Marzo = 3,
    Abril = 4,
    Mayo = 5,
    Junio = 6,
    Julio = 7,
    Agosto = 8,
    Septiembre = 9,
    Octubre = 10,
    Noviembre = 11,
    Diciembre = 12
}

