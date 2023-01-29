/*
 * Lucas Johnson
 * SpinY
 * Assignment 2
 * Concrete SpinY Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinY : MonoBehaviour, SpinBehaviour
{
    public void Spin(Transform objectToSpin)
    {
        objectToSpin.Rotate(0, 1f, 0);
    }
}
