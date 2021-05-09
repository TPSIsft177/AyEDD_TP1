using System;

namespace Common
{
    public static class Reader<T>
    {
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