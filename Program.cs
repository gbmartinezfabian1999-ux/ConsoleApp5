using System;

// Clase Estudiante
class Estudiante
{
    public string Nombre { get; set; }

    public Estudiante(string nombre)
    {
        Nombre = nombre;
    }
}

// AGREGACIÓN
class Universidad
{
    private Estudiante estudiante;

    public Universidad(Estudiante estudiante)
    {
        this.estudiante = estudiante;
    }

    public void MostrarEstudiante()
    {
        Console.WriteLine("Estudiante: " + estudiante.Nombre);
    }
}

// Clase Motor
class Motor
{
    public void Encender()
    {
        Console.WriteLine("El motor está encendido.");
    }
}

// COMPOSICIÓN
class Automovil
{
    private Motor motor;

    public Automovil()
    {
        motor = new Motor();
    }

    public void Encender()
    {
        motor.Encender();
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("RELACIONES ENTRE CLASES");
        Console.WriteLine("========================");

        // AGREGACIÓN
        Console.WriteLine("\n--- AGREGACIÓN ---");

        Estudiante estudiante = new Estudiante("Carlos");
        Universidad universidad = new Universidad(estudiante);

        universidad.MostrarEstudiante();

        Console.WriteLine("El estudiante puede existir independientemente de la universidad.");

        // COMPOSICIÓN
        Console.WriteLine("\n--- COMPOSICIÓN ---");

        Automovil automovil = new Automovil();

        automovil.Encender();

        Console.WriteLine("El motor pertenece al automóvil y se crea dentro de él.");

        Console.WriteLine("\nPrograma finalizado.");
    }
}