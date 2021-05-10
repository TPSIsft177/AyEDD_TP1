using System;
using Common;

//Se ingresan 5 letras informar la cantidad de vocales
namespace Exercise4
{
    class Exercise4 : IExercise
    {
        public void Execute()
        {
            var vowels = "AEIOU";
            var quantity = 0;
            
            Console.WriteLine("Ingrese 5 letras: ");
            for (int i = 0; i < 5; i++)
            {
                if (vowels.Contains(Char.ToUpper(Console.ReadKey().KeyChar)))
                {
                    quantity++;
                }
            }
            
            Console.WriteLine();
            
            switch (quantity)
            {
                case 0: Console.WriteLine("No se ingresaron vocales.");
                    break;
                case 1: Console.WriteLine("Se ingresó " + quantity + " vocal.");
                    break;
                default: Console.WriteLine("Se ingresaron " + quantity + " vocales.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            IExercise exercise = new Exercise4();
            exercise.Execute();
        }
    }
}