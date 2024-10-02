using System.Reflection.Metadata;

namespace konsola
{
    internal class Program
    {
        /*
        *******************************************************
         nazwa funkcji: FindPrimeNumbers
         parametry wejściowe: arr - tablica wartości logicznych
         wartość zwracana: brak
         informacje: Funkcja znajduje liczby pierwsze algorytmem Eratostenesa
         autor: 00000000000
        ****************************************************
        */
        static void FindPrimeNumbers(bool[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(arr.Length - 1); i++)
            {
                if (arr[i] == true)
                {
                    for (int j = 2 * i; j <= arr.Length - 1; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }

            Console.Write("Liczby pierwsze: ");
            for (int i = 2; i <= arr.Length - 1; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write(i + ";");
                }
            }
        }

        static void Main(string[] args)
        {
            int n = 100;
            bool[] array = new bool[n + 1];
            FindPrimeNumbers(array);
        }
    }
}