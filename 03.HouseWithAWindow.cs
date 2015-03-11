using System;
using System.Globalization;
using System.Threading;

class HouseWithAWindow
    {
        static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int halfN = n / 2;
        int spacesBefore = n - 1;
        int middleSpaces = 1;
        Console.Write(new string('.', spacesBefore));
        Console.Write("*");
        Console.Write(new string('.', spacesBefore));
        spacesBefore--;
        Console.WriteLine();
        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', spacesBefore));
            Console.Write("*");
            Console.Write(new string('.', middleSpaces));
            Console.Write("*");
            Console.Write(new string('.', spacesBefore));
            spacesBefore--;
            middleSpaces += 2;
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', 2*n-1));
        for (int i = 0; i < halfN/2; i++)
        {
            Console.Write("*");
            Console.Write(new string('.', (2*n)-3));
            Console.Write("*");
            Console.WriteLine();
        }

        middleSpaces = (2 * n - 1) - (n + 2);
        for (int i = 0; i < (n / 2); i++)
        {
            Console.Write("*");
            Console.Write(new string('.', n /2));
            Console.Write(new string('*', middleSpaces));
            Console.Write(new string('.', n / 2));
            Console.Write("*");
            Console.WriteLine();
        }
        for (int i = 0; i < halfN / 2; i++)
        {
            Console.Write("*");
            Console.Write(new string('.', (2 * n) - 3));
            Console.Write("*");
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', 2 * n - 1));
    }
}
