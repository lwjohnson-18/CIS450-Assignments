/*
 * Lucas Johnson
 * Sphere
 * Assignment 2
 * Concrete Sphere Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private void Start()
    {
        SetSpinBehaviour(new SpinX());
    }

    private void Update()
    {
        PerformSpin();

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SetSpinBehaviour(new SpinX());
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SetSpinBehaviour(new SpinY());
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SetSpinBehaviour(new SpinZ());
        }
    }

    public override void PerformSpin()
    {
        spinBehaviour.Spin(transform);
    }

}
