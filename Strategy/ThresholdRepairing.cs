namespace Strategy;

public class ThresholdRepairing: RepairStrategy
{
    public override void Repair()
    {
        Console.WriteLine("Механик меняет порог автомобиля...");
    }
}