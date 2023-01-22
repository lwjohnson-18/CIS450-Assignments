/*
 * Lucas Johnson
 * Archer
 * Assignment 1
 * MultiClass Class
 */

public class MultiClass : Enemy, I_Archer, I_Brawler
{
    public override void RunAway()
    {
        UnityEngine.Debug.Log(name + " dropped their weapons and ran away");
    }

    public void FireBow()
    {
        UnityEngine.Debug.Log(name + " fired their bow");
    }


    public void SwingSword()
    {
        UnityEngine.Debug.Log(name + " swung their sword");
    }
}
