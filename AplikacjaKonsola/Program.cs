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
        }
    }
}
