namespace SpaceBattle.Lib;
public class TurnCommand : ICommand
{
    private readonly ITurnable iturnable;
    public TurnCommand(ITurnable turnable)
    {
        iturnable = turnable;
    }
    public void Execute()
    {
        iturnable.Angle += iturnable.DeltaAngle;
    }
}
