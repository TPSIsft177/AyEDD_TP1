using System;
using Common;

/*Diseñar un algoritmo que permita ingresar dos números e informar las relaciones existentes
 entre ambos (mayor, menor, igual).*/
namespace Exercise6
{
    class Exercise6: IExercise
    {
        public void Execute()
        {
            const string inputMessage = "Ingrese un número";
            const string errorMessage = "Debe ingresar al menos un número.";
            var value1 = Reader<float>.ReadFromCommandLine(inputMessage, errorMessage);
            var value2 = Reader<float>.ReadFromCommandLine(inputMessage, errorMessage);
            //value1 > value2 => 1
            //value1 < value2 => -1
            //value1 == value2 => 0
            if (value1.CompareTo(value2) == 0)
            {
                Console.WriteLine(value1 + " es es igual a " + value2);
            }
            else if(value1.CompareTo(value2) < 0)
            {
                Console.WriteLine(value1 + " es menor que " + value2);
            }
            else
            {
                Console.WriteLine(value1 + " es mayor que " + value2);
            }
            
        }
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise6();
            exercise.Execute();
        }
    }
}