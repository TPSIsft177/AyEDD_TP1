using System;
using Common;

//Se ingresa un número informar si el mismo es positivo, negativo o cero.
namespace Exercise5
{
    class Exercise5 : IExercise
    {
        public void Execute()
        {
            var number = Reader<float>.ReadFromCommandLine("Ingrese un número: ", "Debe ingresar al menos un número.");

            if (number > 0)
            {
                Console.WriteLine("El número ingresado " + number + " es positivo");
            }
            else if (number < 0)
            {
                Console.WriteLine("El número ingresado " + number + " es negativo");
            }
            else
            {
                Console.WriteLine("El número ingresado es cero");
            }
        }
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise5();
            exercise.Execute();
        }
    }
}