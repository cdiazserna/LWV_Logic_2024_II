using Ejercicio37_PrimerProgramaPOO;

public class Program
{
    private static void Main(string[] args)
    {
        /*37.Desarrollar un programa en C# utilizando los conceptos básicos de la Programación Orientada a Objetos (POO) y bucles para permitir la creación y presentación de N personas. El programa debe solicitar al usuario el número de personas que desea ingresar, obtener los datos de cada una (nombre y edad), y luego mostrar una presentación de cada persona junto con la verificación de si es mayor de edad.*/
        
        //Solicitar por pantalla cuántas personas quiro presentar y validar su mayoría de edad
        Console.WriteLine("¿Cuántas personas quieres presentar?");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ingresa el nombre de la persona:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa la edad de la persona:");
            int edad = Convert.ToInt32(Console.ReadLine());

            //VAMOS a crear una nueva instancia de la clase Personas, ESTO SIGNIFICA QUE VAMOS A CREAR UN NUEVO OBJETO DE LA CLASE PERSONAS

            Personas personas = new Personas(); //Estamos creando un nuevo objeto de la clase Personas

            //Vamos a asignar los valores que el usuario ingresó a las propiedades de la clase Personas
            personas.Nombre = nombre; //Juan
            personas.Edad = edad; //20

            //Me falta invocar los métodos de la clase Personas
            personas.Presentar();
            personas.EsMayorDeEdad();
        }
    }
}