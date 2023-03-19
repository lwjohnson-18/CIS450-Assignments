using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public CoreObject[] CoreObjects;

    private CoreObject _currentObject;
    private ObjectController _objectController;

    private void Start()
    {
        _objectController = new ObjectController();
        _currentObject = CoreObjects[0];
    }

    // Update is called once per frame
    void Update()
    {
        SelectObject();
        ApplyChanges();
    }

    void SelectObject()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            _currentObject = CoreObjects[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _currentObject = CoreObjects[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _currentObject = CoreObjects[2];
        }
    }

    void ApplyChanges()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ICommand changeShapeCommand = new ChangeShapeCommand(_currentObject);
            _objectController.AddCommand(changeShapeCommand);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            ICommand changeColorCommand = new ChangeColorCommand(_currentObject);
            _objectController.AddCommand(changeColorCommand);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            _objectController.UndoCommand();
        }
    }
}
