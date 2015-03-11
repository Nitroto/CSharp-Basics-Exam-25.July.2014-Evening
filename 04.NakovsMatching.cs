using System;
using System.Globalization;
using System.Threading;

class NakovsMatching
{
    static int GetWeight(string part)
    {
        int weight = 0;
        foreach (char value in part)
        {
            weight += value;
        }
        return weight;
    }
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());
        bool noMatches = true;
        for (int i = 1; i < a.Length; i++)
        {
            string leftPartFirst = a.Substring(0, i);
            string rightPartFirst = a.Substring(i);
            int weightLeftFirst = GetWeight(leftPartFirst);
            int weightRightFirst = GetWeight(rightPartFirst);
            for (int j = 1; j < b.Length; j++)
            {
                string leftPartSecond = b.Substring(0, j);
                string rightPartSecond = b.Substring(j);
                int weightLeftSecond = GetWeight(leftPartSecond);
                int weightRightSecond = GetWeight(rightPartSecond);
                int diff = Math.Abs((weightLeftFirst * weightRightSecond) - (weightRightFirst * weightLeftSecond));
                if (diff <= d)
                {
                    noMatches = false;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", leftPartFirst, rightPartFirst, leftPartSecond, rightPartSecond, diff);
                }
            }
        }
        if (noMatches)
        {
            Console.WriteLine("No");
        }
    }
}
