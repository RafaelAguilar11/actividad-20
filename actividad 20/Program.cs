using System;
class Paciente
{
    private string nombre;
    private string dpi;
    private string telefono;
    private int edad;

        public string Nombre { get { return nombre; }
        set
        {
            if (value == null || value == "" || value.Length < 3)
            {
                Console.WriteLine("El nombre debe tener al menos 3 caracteres");
                return;
            }

            nombre = value;
        }

        public string DPI
    {
        get { return dpi; }
        set
        {
            if (value == null || value == "" || value.Length != 13)
            {
                Console.WriteLine("El DPI debe tener exactamente 13 dígitos numéricos");
                return;
            }

            long numero;
            if (!long.TryParse(value, out numero))
            {
                Console.WriteLine("El DPI debe contener solo números");
                return;
            }

            dpi = value;
        }
    }
    public string Telefono
    {
        get { return telefono; }
        set
        {
            if (value == null || value == "" || value.Length != 8)
            {
                Console.WriteLine("El teléfono debe tener 8 dígitos numéricos");
                return;
            }

            int numero;
            if (!int.TryParse(value, out numero))
            {
                Console.WriteLine("El teléfono debe contener solo números");
                return;
            }

            telefono = value;
        }
    }

    public int Edad
    {
        get { return edad; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("La edad debe ser mayor a 0");
                return;
            }

            edad = value;
        }
    }

    public Paciente(string nombre, string dpi, string telefono, int edad)
    {
        this.Nombre = nombre;
        this.DPI = dpi;
        this.Telefono = telefono;
        this.Edad = edad;
    }

    public void MostrarPaciente()
    {
        Console.WriteLine("\n--- DATOS DEL PACIENTE ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"DPI: {dpi}");
        Console.WriteLine($"Teléfono: {telefono}");
        Console.WriteLine($"Edad: {edad}");
    }
}