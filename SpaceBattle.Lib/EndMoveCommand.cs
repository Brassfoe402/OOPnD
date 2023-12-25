using Hwdtech;
using Hwdtech.Ioc;

namespace SpaceBattle.Lib;

public class EndMoveCommand : ICommand
{
    private IMoveCommandEndable iend;

    public EndMoveCommand(IMoveCommandEndable end)
    {
        iend = end;
    } 

    public void Execute()
    {
        var Empty = IoC.Resolve<ICommand>("Command.Empty");
        iend.Properties.ToList().ForEach(pair => IoC.Resolve<ICommand>("DeleteProperty", iend.Uobject, pair).Execute());
        var command = IoC.Resolve<IBridgeCommand>("GetProperty", iend.Uobject, iend.NameCommand);

        IoC.Resolve<IBridgeCommand>("Command.Inject", command, Empty);
    }
}
