using System;
using Common;

//Desarrollar un algoritmo que permita ingresar un número e informe si el mismo es mayor que 50.
namespace Exercise1
{
    class Exercise1 : IExercise
    {
        public void Execute()
        { 
            var floatValue = Reader<float>.ReadFromCommandLine("Ingrese un número: ", "Ingrese un número válido."); 
            if (floatValue > 50)
            { 
               Console.WriteLine("El valor ingresado " + floatValue + " es mayor que 50");   
            }
        }
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise1();
            exercise.Execute();
        }
    }
}