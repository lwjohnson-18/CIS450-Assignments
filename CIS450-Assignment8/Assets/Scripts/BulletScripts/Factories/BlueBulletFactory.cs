/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 6
 * Used to spawn blue bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBulletFactory : BulletFactory
{
    public override GameObject CreateBullet(Vector3 position, Quaternion rotation)
    {
        GameObject newBullet = InstantiateBullet(position, rotation);
        newBullet.AddComponent<BlueBullet>();
        return newBullet;
    }
}
