namespace Ejercicio37_PrimerProgramaPOO
{
    public class Personas
    {
        //Propiedades de mi clase Personas:
        public string Nombre { get; set; } //Forma de definir mis propiedades getters and setters

        public int Edad { get; set; }


        //Método de mi clase Personas:

        //Esta es la forma de crear un método en C#:
        //Modificador de acceso + tipo de dato que retorna el método + nombre del método + sección de parámetros ()
        public void Presentar() //Void significa que el método no retorna NADA
        {
            Console.WriteLine($"Hola! Mi nombre es {Nombre} y tengo {Edad} años.");
        }

        //Segundo método para validar si la persona es mayor de edad o no:
        public void EsMayorDeEdad()
        {
            if (Edad >= 18)
            {
                Console.WriteLine("Soy mayor de edad.");
            }
            else
            {
                Console.WriteLine("Soy menor de edad.");
            }
        }
    }
}
