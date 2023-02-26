/*
 * Lucas Johnson
 * BulletBehaviour
 * Assignment 6
 * Used to spawn bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class BulletFactory : MonoBehaviour
{
    public GameObject bulletPrefab;

    public GameObject InstantiateBullet(Vector3 position, Quaternion rotation)
    {
        GameObject newBullet = Instantiate(bulletPrefab, position, rotation);
        return newBullet;
    }

    public abstract GameObject CreateBullet(Vector3 position, Quaternion rotation);
}
