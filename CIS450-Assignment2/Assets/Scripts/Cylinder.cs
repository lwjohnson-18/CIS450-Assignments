/*
 * Lucas Johnson
 * Cylinder
 * Assignment 2
 * Concrete Cylinder Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private void Start()
    {
        SetSpinBehaviour(new SpinX());
    }

    private void Update()
    {
        PerformSpin();

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetSpinBehaviour(new SpinX());
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SetSpinBehaviour(new SpinY());
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SetSpinBehaviour(new SpinZ());
        }
    }

    public override void PerformSpin()
    {
        spinBehaviour.Spin(transform);
    }
}
