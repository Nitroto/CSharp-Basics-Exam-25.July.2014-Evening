using System;
using System.Globalization;
using System.Threading;
class OddAndEvenJumps
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string phrase = Console.ReadLine().ToLower().Replace(" ", "");
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());
        int position = 1;
        int oddLetter = 0;
        int evenLetter = 0;
        long oddSum = 0;
        long evenSum = 0;
        foreach (char letter in phrase)
        {
            if (position % 2 == 1)
            {
                oddLetter++;
                if (oddLetter % oddJump == 0)
                {
                    oddSum *= (int)letter;
                }
                else
                {
                    oddSum += (int)letter;
                }
            }
            else
            {
                evenLetter++;
                if (evenLetter % evenJump == 0)
                {
                    evenSum *= (int)letter;
                }
                else
                {
                    evenSum += (int)letter;
                }
            }
            position++;
        }
        Console.WriteLine("Odd: {0:X}", oddSum);
        Console.WriteLine("Even: {0:X}",evenSum);
    }
}
