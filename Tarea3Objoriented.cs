using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    protected string nombre, segsoc;

    public Person()
    {
        nombre = "";
        segsoc = "";
        Console.WriteLine("Object Person created");
    }

    ~Person()
    {
        Console.WriteLine("Object Person destroyed");
    }
}

class Empleado : Person
{
    private double pagaporhora, horastrabajadas;

    public Empleado()
    {
        pagaporhora = 0;
        horastrabajadas = 0;
        Console.WriteLine("Object Student created");
    }

    ~Empleado()
    {
        Console.WriteLine("Object Student destroyed");
    }

    public double unapaga
    {
        set
        {
            pagaporhora = value;
        }

        get
        {
            return pagaporhora;
        }
    }

    public double unashorastrabajadas
    {
        set
        {
            horastrabajadas = value;
        }

        get
        {
            return horastrabajadas;
        }
    }

    public string unnombre
    {
        set
        {
            nombre = value;
        }

        get
        {
            return nombre;
        }
    }

    public string unsegsoc
    {
        set
        {
            segsoc = value;
        }

        get
        {
            return segsoc;
        }
    }

    public double chequesemanal
    {
        get
        {
            return (pagaporhora * horastrabajadas);
        }
    }
}

class Demo
{
    static void Main()
    {
        Empleado empleado = new Empleado();

        Console.Write("\nEnter Name: ");
        empleado.unnombre = Console.ReadLine();

        Console.Write("\nEnter Social Security Number: ");
        empleado.unnombre = Console.ReadLine();

        Console.Write("\nEnter hourly pay of employee: ");
        empleado.unapaga = double.Parse(Console.ReadLine());

        Console.Write("\nEnter hours worked of employee: ");
        empleado.unashorastrabajadas = double.Parse(Console.ReadLine());

        Console.WriteLine("\nInformacion del empleado");
        Console.WriteLine("nombre: " + empleado.unnombre);
        Console.WriteLine("Seguro Social: " + empleado.unsegsoc);
        Console.WriteLine("Paga por hora: " + empleado.unapaga);
        Console.WriteLine("Horas trabajadas: " + empleado.unashorastrabajadas);
        Console.WriteLine("Cheque Mensual: " + empleado.chequesemanal);
    }
}

