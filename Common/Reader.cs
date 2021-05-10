using System;

namespace Common
{
    public static class Reader<T>
    {
        /**
         * Recupera el dato ingresado desde la consola y lo convierte al tipo de dato indicado en T y
         * valida que el mismo pueda ser convertido, de lo contrario solicita un nuevo ingreso.
         */
        public static T ReadFromCommandLine(string inputMessage, string errorMessage)
        {
            T number = default;
            bool validValue = false;
            do
            {
                try
                {
                    Console.WriteLine(inputMessage);
                    number = (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
                    validValue = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ocurrió el siguiente error: " + e.Message +". " + errorMessage);
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (!validValue);
            return number;
        }
    }
}