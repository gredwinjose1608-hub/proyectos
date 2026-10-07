const double PI= 3.1416;
const double RADIO= 8.0;
const double ALTURA= 12.0;
const double BASE= 10.0;

double Area_del_circulo = PI*RADIO*RADIO;
double Volumen_del_cilindro = PI*RADIO*RADIO*ALTURA;
double Area_del_triangulo = (BASE*ALTURA)/2;
double Circunferencia_calculada = 2*PI*RADIO;

Console.WriteLine(" " );
Console.WriteLine("valores a mostrar:" );
Console.WriteLine("PI =" +PI);
Console.WriteLine("Radio = " +RADIO);
Console.WriteLine("Altura = " +ALTURA);
Console.WriteLine("Base = " +BASE);
Console.WriteLine("Area_del_circulo;= " + Area_del_circulo);
Console.WriteLine("Volumen_del_cilindro = " + Volumen_del_cilindro);
Console.WriteLine("Area_del_triangulo = " + Area_del_triangulo);
Console.WriteLine("Circunferencia_calculada = " + Circunferencia_calculada);

