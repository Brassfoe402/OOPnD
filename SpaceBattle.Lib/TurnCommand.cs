namespace SpaceBattle.Lib;
public class Turn : ICommand
{
    private readonly ITurnable iturnable;
    public Turn(ITurnable turnable)
    {
        iturnable = turnable;
    }
    public void Execute()
    {
        iturnable.Angle += iturnable.AngleVelocity;
    }
}
