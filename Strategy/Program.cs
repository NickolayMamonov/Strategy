using Strategy;

public class Program
{
    private static void Main(string[] args)
    {
        Mechanic mechanic = new Mechanic();
        mechanic.SetRepairStrategy(new ClutchRepairing());
        mechanic.Repair();
        mechanic.SetRepairStrategy(new ThresholdRepairing());
        mechanic.Repair();
        mechanic.SetRepairStrategy(new BrakeSystemRepairing());
        mechanic.Repair();
    }
}