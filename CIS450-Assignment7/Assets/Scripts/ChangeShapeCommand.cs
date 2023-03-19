
using UnityEngine;

public class ChangeShapeCommand : ICommand
{
    CoreObject _coreObject;

    int _previousMesh;

    public ChangeShapeCommand(CoreObject coreObject)
    {
        _coreObject = coreObject;
        _previousMesh = _coreObject.CurrentMesh;
    }

    public void Execute()
    {
        _coreObject.ChangeShape();
    }

    public void Undo()
    {
        _coreObject.SetShape(_previousMesh);
    }
}
