using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Programa demuestra el manejo de un array desordenado y que admite

//duplicados. Se usa una clase para encapsular las funciones del array



class UnorderedList
{ 

    private int elem; //Cantidad de elementos llenos

    private int[] a;  //Variable para el array



    //Constructor

    public UnorderedList(int dim)

    {

        a = new int[dim]; //Declaro el array

        elem = 0;         //No hay elementos

    }



    //Destructor

    ~UnorderedList()

    {

        Console.WriteLine("Array destruido.");

    }



    //Método para buscar un valor en el array.

    public int Buscar(int valor)

    {

        for (int j = 0; j < elem; j++)

        {

            if (a[j] == valor)   //¿Se encontró?

                return j;         //Sí, se encontró. Salir del for loop.

        }

        return -1;              //No se encontró

    }



    //Método para insertar un valor.

    public void Insertar(int valor)

    {

        a[elem] = valor;

        elem++;  //Hay un elemento más con valor

    }



    //Método para eliminar un valor del array


    public int Eliminar(int valor)

    {

        int eliminados = 0;

        int j;

        do

        {

            j = Buscar(valor);   //Buscar el valor

            if (j >= 0)          //Se encontró el valor

            {

                for (int k = j; k < elem - 1; k++)  //Mudar los elementos

                {                                   //posteriores un elemento

                    a[k] = a[k + 1];                 //hacia abajo.

                }

                elem--;        //Hay un elemento menos con valor

                eliminados++;  //Hay un valor más eliminado

            }

        }

        while (j >= 0);

        return eliminados;

    }



    //Método para mostrar los elementos del array.

    public void Mostrar()

    {



        Console.WriteLine();

        for (int j = 0; j < elem; j++)

            Console.Write(a[j] + " ");

        Console.WriteLine("\n");

    }



} //Fin de clase



class UnorderedListDemo

{

    static void Main()

    {

        //Crear un objeto UnorderedList de 100 números enteros

        UnorderedList a = new UnorderedList(100);



        //Insertar 5 valores en la lista

        a.Insertar(17);

        a.Insertar(57);

        a.Insertar(77);

        a.Insertar(23);

        a.Insertar(77);

        a.Insertar(44);



        //Mostrar la lista

        a.Mostrar();



        //Buscar el valor 23

        int indice = a.Buscar(23);

        if (indice > 0) //¿Se encontró?

            Console.WriteLine("Se encontró el valor 23 " +

               "en el índice " + indice + ".");

        else

            Console.WriteLine("No se encontró el valor 23.");



        //Ahora eliminar el valor 77

        int eliminado = a.Eliminar(77);

        if (eliminado > 0)

            Console.WriteLine("Se eliminaron " + eliminado +

               " valores 77.");

        else

            Console.WriteLine("No se encontró el valor 77.");



        //Ahora tratar de eliminar un valor que no

        //exista como, por ejemplo, el 12.

        eliminado = a.Eliminar(12);

        if (eliminado > 0)

            Console.WriteLine("Se eliminaron " + eliminado +

               " valores 12.");

        else

            Console.WriteLine("No se encontró el valor 12.");



        //También tratar de añadir un valor que ya existe

        a.Insertar(23);



        //Mostrar de nuevo la lista

        a.Mostrar();

    }



} //Fin de clase

