namespace LCP_Technical_Exercise_Challenge
{
    public class Exercise
    {
        public static int[] Decompose(int n)
        {
            n *= n;

            int[] intArray = new int[n + 1];
            Array.Fill<int>(intArray, -1, 0, n + 1);
            intArray[1] = 1;

            for (var i = 2; i <= n; i++)
            {
                for (var j = (int)Math.Sqrt(i); j >= 1; j--)
                {
                    if (intArray[i - j * j] != -1 && j > intArray[i - j * j])
                    {
                        intArray[i] = j;
                        break;
                    }
                }
            }

            List<int> result = new List<int>();
            int currentValue = n;

            while (intArray[currentValue] != -1)
            {
                result.Add(intArray[currentValue]);
                currentValue -= intArray[currentValue] * intArray[currentValue];
            }

            result.Sort();
            int[] finalResult = result.ToArray();

            if (finalResult.Length == 0) finalResult = null;

            return finalResult;
        }
    }
}