using System;

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Genero { get; set; }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Género: {Genero}");
    }
}

class Empleado : Persona
{
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salario: ${Salario}");
    }
}

class Estudiante : Persona
{
    public string ProgramaEstudio { get; set; }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Programa de estudio: {ProgramaEstudio}");
    }
}

class ExAlumno : Persona
{
    public DateTime FechaGraduacion { get; set; }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Fecha de graduación: {FechaGraduacion.ToShortDateString()}");
    }
}

class Docente : Persona
{
    public string Asignatura { get; set; }
    public double Salario { get; set; }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Asignatura: {Asignatura}");
        Console.WriteLine($"Salario: ${Salario}");
    }
}

class Administrativo : Persona
{
    public string Area { get; set; }
    public double Salario { get; set; }

    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Área: {Area}");
        Console.WriteLine($"Salario: ${Salario}");
    }
}

class Administrador : Empleado
{
    public Administrador(string nombre, int edad, string genero, double salario)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Cargo = "Administrador";
        Salario = salario;
    }
}

class Maestro : Docente
{
    public Maestro(string nombre, int edad, string genero, string asignatura, double salario)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Asignatura = asignatura;
        Salario = salario;
    }
}

class Program
{
    static void Main()
    {
        Empleado empleado1 = new Empleado
        {
            Nombre = "Juan Perez",
            Edad = 35,
            Genero = "Masculino",
            Cargo = "Gerente de Ventas",
            Salario = 50000
        };

        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Maria Garcia",
            Edad = 20,
            Genero = "Femenino",
            ProgramaEstudio = "Ingeniería Informática"
        };

        ExAlumno exalumno1 = new ExAlumno
        {
            Nombre = "Carlos Rodriguez",
            Edad = 28,
            Genero = "Masculino",
            FechaGraduacion = new DateTime(2020, 5, 15)
        };

        Docente docente1 = new Docente
        {
            Nombre = "Ana Lopez",
            Edad = 40,
            Genero = "Femenino",
            Asignatura = "Matemáticas",
            Salario = 60000
        };

        Administrativo administrativo1 = new Administrativo
        {
            Nombre = "Laura Martinez",
            Edad = 30,
            Genero = "Femenino",
            Area = "Recursos Humanos",
            Salario = 45000
        };

        Administrador administrador1 = new Administrador("Pedro Ramirez", 45, "Masculino", 75000);

        Maestro maestro1 = new Maestro("Luis Torres", 50, "Masculino", "Historia", 70000);

        Console.WriteLine("Información del Empleado:");
        empleado1.MostrarInformacion();

        Console.WriteLine("\nInformación del Estudiante:");
        estudiante1.MostrarInformacion();

        Console.WriteLine("\nInformación del Ex Alumno:");
        exalumno1.MostrarInformacion();

        Console.WriteLine("\nInformación del Docente:");
        docente1.MostrarInformacion();

        Console.WriteLine("\nInformación del Administrativo:");
        administrativo1.MostrarInformacion();

        Console.WriteLine("\nInformación del Administrador:");
        administrador1.MostrarInformacion();

        Console.WriteLine("\nInformación del Maestro:");
        maestro1.MostrarInformacion();
    }
}
