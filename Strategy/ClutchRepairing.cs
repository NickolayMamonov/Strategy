namespace Strategy;

public class ClutchRepairing: RepairStrategy
{
    public override void Repair()
    {
        Console.WriteLine("Механик меняет сцепление автомобиля...");
    }
}