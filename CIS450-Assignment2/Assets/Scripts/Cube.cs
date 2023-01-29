using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void Start()
    {
        SetSpinBehaviour(new SpinX());
    }

    private void Update()
    {
        PerformSpin();

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetSpinBehaviour(new SpinX());
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetSpinBehaviour(new SpinY());
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetSpinBehaviour(new SpinZ());
        }
    }

    public override void PerformSpin()
    {
        spinBehaviour.Spin(transform);
    }
}
