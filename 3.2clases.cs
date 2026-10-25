class ObjetoAstronomico
{       
    public string nombre;
    public double masa;
    public double diametroMedio;
    public double periodoRotacion;

    public ObjetoAstronomico(string nombre, double masa, double diametroMedio, double periodoRotacion)
    {
        this.nombre = nombre;
        this.masa = masa;
        this.diametroMedio = diametroMedio;
        this.periodoRotacion = periodoRotacion;
    }

    public virtual void GetInformation()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Masa: " + masa + " kg");
        Console.WriteLine("Diametro medio: " + diametroMedio + " km");
        Console.WriteLine("Periodo de rotacion: " + periodoRotacion + " dias");
    }
}

class Estrella : ObjetoAstronomico
{
    public Estrella(string nombre, double masa, double diametroMedio, double periodoRotacion)
        : base(nombre, masa, diametroMedio, periodoRotacion)
    {
    }

    public override void GetInformation()
    {
        Console.WriteLine("\n[Estrella]");
        base.GetInformation();
    }
}

class Planeta : ObjetoAstronomico
{
    public string cuerpoOrbita;
    public double periodoTraslacion;
    public double distanciaMedia;
    public double excentricidad;

    public Planeta(string nombre, double masa, double diametroMedio, double periodoRotacion,
                   string cuerpoOrbita, double periodoTraslacion, double distanciaMedia, double excentricidad)
        : base(nombre, masa, diametroMedio, periodoRotacion)
    {
        this.cuerpoOrbita = cuerpoOrbita;
        this.periodoTraslacion = periodoTraslacion;
        this.distanciaMedia = distanciaMedia;
        this.excentricidad = excentricidad;
    }

    public override void GetInformation()
    {
        Console.WriteLine("\n[Planeta]");
        base.GetInformation();
        Console.WriteLine("Orbita a: " + cuerpoOrbita);
        Console.WriteLine("Periodo de traslacion: " + periodoTraslacion + " dias");
        Console.WriteLine("Distancia media: " + distanciaMedia + " km");
        Console.WriteLine("Excentricidad: " + excentricidad);
    }
}

class Satelite : ObjetoAstronomico
{
    public string cuerpoOrbita;
    public double periodoTraslacion;
    public double distanciaMedia;
    public double excentricidad;

    public Satelite(string nombre, double masa, double diametroMedio, double periodoRotacion,
                    string cuerpoOrbita, double periodoTraslacion, double distanciaMedia, double excentricidad)
        : base(nombre, masa, diametroMedio, periodoRotacion)
    {
        this.cuerpoOrbita = cuerpoOrbita;
        this.periodoTraslacion = periodoTraslacion;
        this.distanciaMedia = distanciaMedia;
        this.excentricidad = excentricidad;
    }

    public override void GetInformation()
    {
        Console.WriteLine("\n[Satelite]");
        base.GetInformation();
        Console.WriteLine("Orbita a: " + cuerpoOrbita);
        Console.WriteLine("Periodo de traslacion: " + periodoTraslacion + " dias");
        Console.WriteLine("Distancia media: " + distanciaMedia + " km");
        Console.WriteLine("Excentricidad: " + excentricidad);
    }
}

class Asteroide : ObjetoAstronomico
{
    public string cuerpoOrbita;
    public double periodoTraslacion;
    public double distanciaMedia;
    public double excentricidad;

    public Asteroide(string nombre, double masa, double diametroMedio, double periodoRotacion,
                     string cuerpoOrbita, double periodoTraslacion, double distanciaMedia, double excentricidad)
        : base(nombre, masa, diametroMedio, periodoRotacion)
    {
        this.cuerpoOrbita = cuerpoOrbita;
        this.periodoTraslacion = periodoTraslacion;
        this.distanciaMedia = distanciaMedia;
        this.excentricidad = excentricidad;
    }

    public override void GetInformation()
    {
        Console.WriteLine("\n[Asteroide]");
        base.GetInformation();
        Console.WriteLine("Orbita a: " + cuerpoOrbita);
        Console.WriteLine("Periodo de traslacion: " + periodoTraslacion + " dias");
        Console.WriteLine("Distancia media: " + distanciaMedia + " km");
        Console.WriteLine("Excentricidad: " + excentricidad);
    }
}

class Cometa : ObjetoAstronomico
{
    public string cuerpoOrbita;
    public double periodoTraslacion;
    public double distanciaMedia;
    public double excentricidad;

    public Cometa(string nombre, double masa, double diametroMedio, double periodoRotacion,
                  string cuerpoOrbita, double periodoTraslacion, double distanciaMedia, double excentricidad)
        : base(nombre, masa, diametroMedio, periodoRotacion)
    {
        this.cuerpoOrbita = cuerpoOrbita;
        this.periodoTraslacion = periodoTraslacion;
        this.distanciaMedia = distanciaMedia;
        this.excentricidad = excentricidad;
    }

    public override void GetInformation()
    {
        Console.WriteLine("\n[Cometa]");
        base.GetInformation();
        Console.WriteLine("Orbita a: " + cuerpoOrbita);
        Console.WriteLine("Periodo de traslacion: " + periodoTraslacion + " dias");
        Console.WriteLine("Distancia media: " + distanciaMedia + " km");
        Console.WriteLine("Excentricidad: " + excentricidad);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("SISTEMA SOLAR");

        List<ObjetoAstronomico> objetos = new List<ObjetoAstronomico>();

        objetos.Add(new Estrella("Sol", 1.989e30, 1392700, 25.4));

        objetos.Add(new Planeta("Tierra", 5.972e24, 12742, 1,
            "Sol", 365.25, 149600000, 0.0167));

        objetos.Add(new Satelite("Luna", 7.342e22, 3474.8, 27.3,
            "Tierra", 27.3, 384400, 0.0549));

        objetos.Add(new Asteroide("Vesta", 2.590e20, 525.4, 0.2226,
            "Sol", 1325.75, 353400000, 0.0887));

        objetos.Add(new Cometa("Halley", 2.2e14, 11000, 2.2,
            "Sol", 27500, 2660000000, 0.967));

        foreach (ObjetoAstronomico objeto in objetos)
        {
            objeto.GetInformation();
        }
    }
}