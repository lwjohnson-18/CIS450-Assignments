using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinX : MonoBehaviour, SpinBehaviour
{
    public void Spin(Transform objectToSpin)
    {
        objectToSpin.Rotate(1f, 0, 0);
    }
}
