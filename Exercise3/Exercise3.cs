using System;
using Common;

/*Diseñar un algoritmo que permita a un usuario ingresar dos números, si el primero es
 mayor al segundo informar el producto de ambos, sino informar la sumatoria.*/
namespace Exercise3
{
    class Exercise3 : IExercise
    {
        public void Execute()
        {
            float operation;
            string startMessage = "El producto";
            
            var value1 = Reader<float>.ReadFromCommandLine("Ingrese el primer número: ", "Ingrese un número válido.");
            var value2 = Reader<float>.ReadFromCommandLine("Ingrese el segundo número: ", "Ingrese un número válido.");

            if (value1 > value2)
            {
                operation = value1 * value2;
            }
            else
            {
                operation = value1 + value2;
                startMessage = "La sumatoria";
            }
            
            Console.WriteLine(startMessage + " de los números " + value1 + " y " + value2 + " es: " + operation);
        }
        
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise3();
            exercise.Execute();
        }
    }
}