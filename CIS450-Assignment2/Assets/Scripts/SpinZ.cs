using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinZ : MonoBehaviour, SpinBehaviour
{
    public void Spin(Transform objectToSpin)
    {
        objectToSpin.Rotate(0, 0, 1f);
    }
}
