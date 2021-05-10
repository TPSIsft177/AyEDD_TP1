using System;
using Common;

// Se ingresa un número, siendo el mismo 99 < N < 1000, se pide informar la suma de sus cifras.
namespace Exercise8
{
    class Exercise8 : IExercise
    {
        public void Execute()
        {
            const string inputMessage = "Ingrese un número mayor a 99 y menor a 1000:";
            const string errorMessage = "Debe ingresar al menos un número.";
            var number = Reader<int>.ReadFromCommandLine(inputMessage, errorMessage);
            
            if (number is > 99 and < 1000)
            {
                Console.WriteLine("La suma de los dígitos del número " + number + " es: " + SumAllDigits(number));
            }
            else
            {
                Console.WriteLine("El número ingresado debe ser mayor que 99 y menor que 1000.");
                Console.ReadKey();
                Console.Clear();
                Execute();
            }
        }

        private int SumAllDigits(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                var nextValueForNumber = number / 10;
                var rest = 0;
                
                if (nextValueForNumber >= 10)
                {
                    rest = number % 10;
                    number = nextValueForNumber;
                }
                else
                {
                    rest = number % 10;
                    rest = rest + nextValueForNumber;
                    number = 0;
                }
                
                sum = sum + rest;
            }

            return sum;

        }
        
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise8();
            exercise.Execute();
        }
    }
}