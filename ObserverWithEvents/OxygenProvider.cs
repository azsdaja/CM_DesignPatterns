namespace Observer
{
    using System;

    public class OxygenProvider
    {
        public bool IsOn { get; private set; }
        public void ManageOxygenProviderBasingOnHeight(int height)
        {
            if (height > 7000 && IsOn == false)
            {
                IsOn = true;
                Console.WriteLine("Uruchomiono podajnik tlenu.");
            }

            if (height < 6000 && IsOn == true)
            {
                IsOn = false;
                Console.WriteLine("Wyłączono podajnik tlenu");
            }
        }
    }
}