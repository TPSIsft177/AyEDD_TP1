using System;
using Common;

/*Se ingresan las marcas diarias de temperatura de una semana, se pide informar la
cantidad de días en que la temperatura fue mayor a 21 grados.*/
namespace Exercise9
{
    class Exercise9 : IExercise
    {
        public void Execute()
        {
            var quantity = ReadDegreesByDayAndCountGreaterThanIndicatedDegrees(21f, 7);
            ShowMessage(quantity);
        }

        private static int ReadDegreesByDayAndCountGreaterThanIndicatedDegrees(float degrees, int quantityOfDays)
        {
            var dayCounter = 0;
            var quantity = 0;
            do
            {
                var dayTemperature = Reader<float>.ReadFromCommandLine("Ingrese la temperatura del día " + (dayCounter + 1),
                    "Debe ingresar al menos un número.");
                if (dayTemperature > degrees)
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
            IExercise exercise = new Exercise9();
            exercise.Execute();
        }
    }
}