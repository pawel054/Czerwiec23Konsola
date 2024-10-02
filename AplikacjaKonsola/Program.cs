namespace AplikacjaKonsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            bool[] A = new bool[n+1];
            FillArray(A);
        }


        /* 
        *******************************************************
        nazwa funkcji: FillArray
        parametry wejściowe: bool[] array - przechowuje wartosci true i false
        wartość zwracana: brak
        informacje: Funkcja wypełnia tablicę wartościami true, następnie szuka liczb pierwszych z przediału 2 do n wykorzystując algorytm sita Eratostenesa. Pod koniec wypisuje w konsoli liczby pierwsze z separatorem.
        autor: Paweł Marcisz
        *******************************************************
        */
        private static void FillArray(bool[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }

            for(int i = 2; i <= Math.Sqrt(array.Length-1); i++)
            {
                if (array[i] == true)
                {
                    for(int j = 2*i; j<= array.Length-1; j += i)
                    {
                        array[j] = false;
                    }
                }
            }

            for(int i = 2; i <= array.Length - 1; i++)
            {
                if (array[i] == true)
                {
                    Console.Write(i+ ";");
                }
            }
        }
    }
}
