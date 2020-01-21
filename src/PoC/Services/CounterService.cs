namespace PoC.Services
{
    public class CounterService : ICounterService
    {
        public int Counter { get; private set; }

        public void Increment()
        {
            Counter++;
        }
    }
}
