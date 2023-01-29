/*
 * Lucas Johnson
 * Shape
 * Assignment 2
 * Abstract Shape Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public SpinBehaviour spinBehaviour;

    public void SetSpinBehaviour(SpinBehaviour sb)
    {
        spinBehaviour = sb;
    }

    public abstract void PerformSpin();
}
