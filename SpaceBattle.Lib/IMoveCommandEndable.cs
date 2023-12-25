namespace SpaceBattle.Lib;

public interface IMoveCommandEndable
{
    public IUobject Uobject { get; }
    public string NameCommand { get; }
    public IEnumerable<string> Properties { get; }
}
