/*
 * Lucas Johnson
 * Archer
 * Assignment 1
 * Archer Class
 */

[System.Serializable]
public class Archer : Enemy, I_Archer
{
    public int numArrows;

    public override void RunAway()
    {
        UnityEngine.Debug.Log(name + " dropped their bow and ran away");
    }

    public void FireBow()
    {
        UnityEngine.Debug.Log(name + " fired their bow");
    }
}
