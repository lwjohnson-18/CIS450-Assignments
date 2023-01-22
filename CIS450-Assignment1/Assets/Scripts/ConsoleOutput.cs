/*
 * Lucas Johnson
 * ConsoleOutput
 * Assignment 1
 * Outputs to console
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleOutput : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    public List<I_Brawler> brawlers = new List<I_Brawler>();

    // Start is called before the first frame update
    void Start()
    {
        Brawler brawlerTest = new Brawler();
        Archer archerTest = new Archer();

        brawlerTest.name = "Brawler_Test";
        archerTest.name = "Archer_Test";

        brawlerTest.SwingSword();
        archerTest.FireBow();



        Brawler brawler1 = new Brawler();
        Brawler brawler2 = new Brawler();
        Archer archer1 = new Archer();
        Archer archer2 = new Archer();

        brawler1.name = "Brawler_1";
        brawler2.name = "Brawler_2";
        archer1.name = "Archer_1";
        archer2.name = "Archer_2";

        enemies.Add(brawler1);
        enemies.Add(brawler2);
        enemies.Add(archer1);
        enemies.Add(archer2);

        brawlers.Add(brawler1);
        brawlers.Add(brawler2);



        MultiClass multiClassEnemy = new MultiClass();
        multiClassEnemy.name = "Multi-Class_Enemy";
        enemies.Add(multiClassEnemy);
        brawlers.Add(multiClassEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.RunAway();
            }
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (I_Brawler brawler in brawlers)
            {
                brawler.SwingSword();
            }
        }
    }
}
