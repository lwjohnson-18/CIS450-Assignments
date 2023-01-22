/*
 * Lucas Johnson
 * Brawler
 * Assignment 1
 * Brawler Class
 */

[System.Serializable]
public class Brawler : Enemy, I_Brawler
{
    public bool dualWield;

    public override void RunAway()
    {
        UnityEngine.Debug.Log(name + " dropped their sword and ran away");
    }

    public void SwingSword()
    {
        UnityEngine.Debug.Log(name + " swung their sword");
    }
}
