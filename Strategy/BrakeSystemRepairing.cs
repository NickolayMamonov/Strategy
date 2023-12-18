namespace Strategy;

public class BrakeSystemRepairing: RepairStrategy
{
    public override void Repair()
    {
        Console.WriteLine("Механик прокачивает тормозную систему...");
    }
}