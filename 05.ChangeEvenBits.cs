using System;
using System.Globalization;
using System.Threading;

class ChangeEvenBits
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n + 1];
        int changes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            int bit = 0;
            int bitCount = Convert.ToString(nums[i], 2).Length;
            for (int j = 0; j < bitCount; j++)
            {
                if ((nums[n] >> bit&1) == 0)
                {
                    nums[n] |= 1 << bit;
                    changes++;

                }
                bit += 2;
            }
        }
        Console.WriteLine(nums[n]);
        Console.WriteLine(changes);
    }
}
