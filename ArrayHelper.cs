using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source.Length == 0 || source.Length == 1)
            {
                throw new ArgumentException();
            }
            int counter = 0;
            int j = source.Length - 1;
            for (int i = 0; i < source.Length / 2; i++)
            {
                if (source[i] == source[j])
                {
                    counter++;
                }
                j--;
            }
            return counter == source.Length / 2 ? "Yes" : "No";
        }
    }
}
