using System;

namespace finder.index
{
    class Program
    {
        static void Main(string[] args)
        {   int num= 5; int[] can = { 7, 45, 34, 8, 6 };
            Console.WriteLine(Finder(num,can));
        }
        static bool Finder(int number,int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (number==arr[i])
                {
                    return true;
                }

            }
            return false;
        }
    }
}
