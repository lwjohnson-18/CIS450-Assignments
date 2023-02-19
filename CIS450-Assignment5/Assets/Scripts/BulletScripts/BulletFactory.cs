/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 5
 * Used to spawn bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    public GameObject[] bulletPrefabs;

    public GameObject SpawnBullet(string bulletColor, Vector3 position, Quaternion rotation)
    {
        if(bulletColor.Equals("Red"))
        {
            GameObject newBullet = Instantiate(bulletPrefabs[0], position, rotation);
            newBullet.AddComponent<RedBullet>();
            return newBullet;
        }
        else if (bulletColor.Equals("Green"))
        {
            GameObject newBullet = Instantiate(bulletPrefabs[1], position, rotation);
            newBullet.AddComponent<GreenBullet>();
            return newBullet;
        }
        else
        {
            GameObject newBullet = Instantiate(bulletPrefabs[2], position, rotation);
            newBullet.AddComponent<BlueBullet>();
            return newBullet;
        }
    }
}
