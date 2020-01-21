namespace PoC.Services
{
    public interface ICounterService
    {
        int Counter { get; }

        void Increment();
    }
}