using System;
using Common;

//Se ingresa un número determinar e informar si el mismo es par o impar.
namespace Exercise2
{
    class Exercise2 : IExercise
    {
        public void Execute()
        {
            var number = Reader<Int64>.ReadFromCommandLine("Ingrese número entero: ", "Ingrese un número válido.");
            if (number % 2 == 0)
            {
                Console.WriteLine("El número ingresado " + number + " es par.");
            }
            else
            {
                Console.WriteLine("El número ingresado " + number + " es impar.");
            }
        }
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise2();
            exercise.Execute();
        }
    }
}