using System;

namespace Лаб_3
{
    class Program
    {
        public static void InsertArray(ref double[][] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new double[rand.Next(1,10)];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(1, 10);
                }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
