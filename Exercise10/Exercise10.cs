using System;
using Common;
/*
Modificar el ejercicio anterior de manera que el algoritmo permita informar la cantidad
de días en que la temperatura se mantuvo entre 21 grados y 24 grados inclusive. 
 */
namespace Exercise10
{
    class Exercise10 : IExercise
    {
        public void Execute()
        {
            var quantity = ReadDegreesByDayAndCountBetweenFromAndToDegrees(21f, 24f, 7);
            ShowMessage(quantity);
        }

        private static int ReadDegreesByDayAndCountBetweenFromAndToDegrees(float degreesFrom, float degreesTo, int quantityOfDays)
        {
            var dayCounter = 0;
            var quantity = 0;
            do
            {
                var dayTemperature = Reader<float>.ReadFromCommandLine("Ingrese la temperatura del día " + (dayCounter + 1),
                    "Debe ingresar al menos un número.");
                if (dayTemperature > degreesFrom && dayTemperature < degreesTo)
                {
                    quantity++;
                }

                dayCounter++;
            } while (dayCounter < quantityOfDays);

            return quantity;
        }

        private static void ShowMessage(int quantity)
        {
            if (quantity == 0)
            {
                Console.WriteLine("Ningún día de la semana superó 21 grados de temperatura.");
            }
            else if (quantity == 1)
            {
                Console.WriteLine(quantity + " día superó los 21 grados de temperatura.");
            }
            else
            {
                Console.WriteLine(quantity + " días supereraron los 21 grados de temperatura.");
            }
        }
        
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise10();
            exercise.Execute();
        }
    }
}