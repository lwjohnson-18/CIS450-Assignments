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
