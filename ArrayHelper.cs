using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new ArgumentException();
            }
            for (int i = 0, j = source.Length - 1; i < source.Length / 2; i++, j--)
            {
                if (source[i] != source[j])
                {
                    return "No";
                }
            }
            return "Yes";
        }
    }
}
