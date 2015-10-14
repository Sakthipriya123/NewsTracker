namespace AnimalInterface
{
    public interface IBird
    {
        string Name { get; set; }
        string Sound { get; set; }
        string MakeSound();
    }
}