
using System.Collections.Generic;

public class ObjectController
{
    public Stack<ICommand> Commands;

    public ObjectController()
    {
        Commands = new Stack<ICommand>();
    }

    public void AddCommand(ICommand newCommand)
    {
        newCommand.Execute();
        Commands.Push(newCommand);
    }

    public void UndoCommand()
    {
        if(Commands.Count > 0)
        {
            ICommand latestCommand = Commands.Pop();
            latestCommand.Undo();
        }
    }
}
