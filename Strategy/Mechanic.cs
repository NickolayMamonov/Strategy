namespace Strategy;

public class Mechanic
{
    private RepairStrategy repairStrategy;

    public void SetRepairStrategy(RepairStrategy repairStrategy)
    {
        this.repairStrategy = repairStrategy;
    }

    public void Repair()
    {
        repairStrategy.Repair();
    }
}