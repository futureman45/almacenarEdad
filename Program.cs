class Program
{

    //Declarar varibles
    static int edad, menor = 0, adulto = 0, adultoMayor = 0, incrementoEdades = 0, i;
    static float sumaEdad = 0;
    static int edadMaxima = int.MinValue; // Inicializar la edad máxima con el valor mínimo posible de un entero
    static int edadMinima = int.MaxValue; // Inicializar la edad mínima con el valor máximo posible de un entero
    static bool esEdadValida = false;


    //============================= FUNCIONES ================================//
    static void ContadorEdad(int edad)
    {

        //============================= CONDIONALES ================================//

        if (edad > 0 && edad <= 120)
        {
            if (edad < 18)
            {
                menor++;
            }
            else if (edad < 60)
            {
                adulto++;
            }
            else
            {
                adultoMayor++;
            }

            incrementoEdades++;
            sumaEdad += edad;

            // Actualizar la edad máxima si la edad actual es mayor

            if (edad > edadMaxima)
            {
                edadMaxima = edad;
            }

            // Actualizar la edad mínima si la edad actual es menor
            if (edad < edadMinima)
            {
                edadMinima = edad;
            }
            return true;

        }
        else
        {
            Console.WriteLine("\nERROR: Haz ingresado una edad inferior a '0' o superior a '120'.\n");
            return false;
        }

    }


    //============================= MÉTODO PRINCIPAL ================================//

    static void Main(string[] args)
    {


        //Bucle para preguntar la edad 10 veces


        while(i<10)
        {
            // Entradas
            Console.WriteLine("Ingresa la Edad: ");
            edad = int.Parse(Console.ReadLine());
            
            esEdadValida = ContadorEdad(edad);
            if(esEdadValida) {
                i++;
            }
        }

        //Salidas
        Console.WriteLine("La cantidad de personas menores de edad es: " + menor);
        Console.WriteLine("La cantidad de personas mayores de edad es: " + adulto);
        Console.WriteLine("La cantidad de adultos mayores es: " + adultoMayor);
        Console.WriteLine("Edades mas baja: " + edadMinima);
        Console.WriteLine("Edade mas alta: " + edadMaxima);
        Console.WriteLine("Edades promedio: " + sumaEdad / incrementoEdades);
        Console.WriteLine("Edades tenidas en cuenta: " + incrementoEdades);
    }

}
