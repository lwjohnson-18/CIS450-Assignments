
using UnityEngine;

public class ChangeColorCommand : ICommand
{
    CoreObject _coreObject;

    Color _previousColor;

    public ChangeColorCommand(CoreObject coreObject)
    {
        _coreObject = coreObject;
        _previousColor = _coreObject.GetComponent<MeshRenderer>().material.color;
    }

    public void Execute()
    {
        _coreObject.SetRandomColor();
    }

    public void Undo()
    {
        _coreObject.SetColor(_previousColor);
    }
}
