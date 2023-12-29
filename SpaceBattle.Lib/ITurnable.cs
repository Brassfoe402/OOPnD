namespace SpaceBattle.Lib;

public interface ITurnable
{
    public VectorAngle Angle { get; set; }
    public VectorAngle DeltaAngle { get; }
}
