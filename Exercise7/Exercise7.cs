using System;
using Common;

/*
 * Sabiendo que el precio unitario de un artículo es de $35,00 desarrollar un algoritmo que
permita informar el importe al ingresar la cantidad, si dicha cantidad es mayor que 10 se
aplicar un descuento del 10%.
 */
namespace Exercise7
{
    class Exercise7 : IExercise
    {
        public void Execute()
        {
            float price = 35.00f;
            const string inputMessage = "Indique la cantidad del artículo:";
            const string errorMessage = "Debe ingresar al menos un número.";
            var quantity = Reader<int>.ReadFromCommandLine(inputMessage, errorMessage);
            var totalPrice = price * quantity;
            
            if (quantity > 10)
            {
                Console.WriteLine("El importe a pagar es: $" + (totalPrice * 0.9));
            }
            else if (quantity is > 0 and <= 10)
            {
                Console.WriteLine("El importe a pagar es: $"+totalPrice);
            } else
            {
                Console.WriteLine("La cantidad ingresada es menor o igual que cero.");
            }
        }
        
        static void Main(string[] args)
        {
            IExercise exercise = new Exercise7();
            exercise.Execute();
        }

    }
}