/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 6
 * Used to spawn green bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBulletFactory : BulletFactory
{
    public override GameObject CreateBullet(Vector3 position, Quaternion rotation)
    {
        GameObject newBullet = InstantiateBullet(position, rotation);
        newBullet.AddComponent<GreenBullet>();
        return newBullet;
    }
}
