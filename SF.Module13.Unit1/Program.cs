namespace SF.Module13.Unit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckAscending(new[] { -1, 2, 3, 4, 8 }));
            Console.WriteLine(CheckAscending(new[] { -1, 2, 3, 10, 8 }));
        }
        static bool CheckAscending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
