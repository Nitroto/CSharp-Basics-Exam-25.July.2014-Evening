using System;
using System.Globalization;
using System.Threading;

class Electricity
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());
        double lampConsumption = 100.53;
        double compConsumption = 125.90;
        DateTime firstPeriodStart = DateTime.Parse("14:00");
        DateTime firstPeriodFinal = DateTime.Parse("18:59");
        DateTime secondPeriodStart = DateTime.Parse("19:00");
        DateTime secondPeriodFinal = DateTime.Parse("23:59");
        DateTime thirdPeriodStart = DateTime.Parse("00:00");
        DateTime thirdPeriodFinal = DateTime.Parse("08:59");
        int lamps = 0;
        int computers = 0;
        if (time >= firstPeriodStart && time <= firstPeriodFinal)
        {
            lamps = 2;
            computers = 2;
        }
        else if (time >= secondPeriodStart && time <= secondPeriodFinal)
        {
            lamps = 7;
            computers = 6;
        }
        else if (time >= thirdPeriodStart && time <= thirdPeriodFinal)
        {
            lamps = 1;
            computers = 8;
        }
        double totalConsumption = floors * flats * (lamps * lampConsumption + computers * compConsumption);
        Console.WriteLine("{0} Watts", (int)totalConsumption);
    }
}
