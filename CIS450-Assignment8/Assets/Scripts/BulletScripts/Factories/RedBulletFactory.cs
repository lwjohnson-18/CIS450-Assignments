/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 6
 * Used to spawn red bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBulletFactory : BulletFactory
{
    public override GameObject CreateBullet(Vector3 position, Quaternion rotation)
    {
        GameObject newBullet = InstantiateBullet(position, rotation);
        newBullet.AddComponent<RedBullet>();
        return newBullet;
    }
}
