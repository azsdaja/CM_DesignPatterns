namespace Observer
{
    public class Baloon
    {
        public delegate void HeightChanged(int height);

        public event HeightChanged HeightChangedEvent;
        
        public int Height { get; set; }
        
        public void NotifyBaloon()
        {
            HeightChangedEvent?.Invoke(Height);
        }
    }
}

