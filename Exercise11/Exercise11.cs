using System;
using Common;

/*Desarrollar un algoritmo que permita al usuario ingresar las edades de 8 personas, al
finalizar los ingresos informar el porcentaje de personas mayores y menores de edad,
Se considera mayor de edad a la persona que tiene 18 años o más. */

namespace Exercise11
{
    public class Exercise11 : IExercise
    {
        public void Execute()
        {
            int younger = 0, adult = 0;
            int totalQuantityOfPersons = 8;
            
            for (int i = 0; i < totalQuantityOfPersons; i++)
            {
                if (GetAge(i) >= 18)
                {
                    adult++;
                }
                else
                {
                    younger++;
                }
            }

            var percentageOfAdults = adult * 100 / totalQuantityOfPersons;
            var percentageOfYoungers = younger * 100 / totalQuantityOfPersons;
            
            Console.WriteLine("El porcentaje de personas mayores de edad es: " + percentageOfAdults + "%" );
            Console.WriteLine("El porcentaje de personas menores de edad es: " + percentageOfYoungers + "%");

        }

        private static int GetAge(int personNumber)
        {
            int age;
            do
            {
                age = Reader<int>.ReadFromCommandLine("Ingrese la edad de la persona " + (personNumber + 1),
                    "Debe ingresar al menos un número.");
                if (age < 0)
                {
                    Console.WriteLine("La edad " + age + " ingresada es inválida. Intente nuevamente");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (age < 0);

            return age;
        }

        static void Main(string[] args)
        {
            IExercise exercise = new Exercise11();
            exercise.Execute();
        }
    }
}