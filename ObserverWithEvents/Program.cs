using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var baloon = new Baloon();

            var oprovider = new OxygenProvider();
            var catapult = new Catapult();
            baloon.HeightChangedEvent += oprovider.ManageOxygenProviderBasingOnHeight;
            baloon.HeightChangedEvent += catapult.FireCatapultIfFallingDown;

            baloon.Height = 10000;
            for (int i = 0; i < 1000; i++)
            {
                if (baloon.Height < 0)
                {
                    Console.WriteLine("No i wylądował i cały misterny plan...");
                    break;
                }
                var heightChange = new Random().Next(-1000, 0);
                baloon.Height += heightChange;
                baloon.NotifyBaloon();

                Console.WriteLine(baloon.Height);
            }
            Console.ReadLine();
        }
    }
}
