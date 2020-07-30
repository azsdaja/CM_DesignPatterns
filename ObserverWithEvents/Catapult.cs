namespace Observer
{
    using System;

    public class Catapult
    {
        public int PreviousHeight { get; set; }

        public void FireCatapultIfFallingDown(int height)
        {
            if (PreviousHeight - height > 50 && height < 2000)
            {
                Console.WriteLine("Tak jakby lecisz w dół typie, odpalam katapultę");
            }
            PreviousHeight = height;
        }
    }
}