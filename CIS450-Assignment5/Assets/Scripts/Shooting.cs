/*
 * Lucas Johnson
 * Shooting
 * Assignment 5
 * Handles shooting of bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public BulletFactory bulletFactory;
    public Transform firePoint;
    public float projectileForce = 20f;
    public float timeBetweenShots = 0.5f;
    public float destroyDelay = 5f;

    private float nextShotTime;

    // Update is called once per frame
    void Update()
    {
        Shoot(KeyCode.Alpha1, "Red");
        Shoot(KeyCode.Alpha2, "Green");
        Shoot(KeyCode.Alpha3, "Blue");
    }

    void Shoot(KeyCode keyCode, string bulletColor)
    {
        if (Input.GetKeyDown(keyCode))
        {
            bool canShoot = Time.time > nextShotTime;

            if (canShoot)
            {
                GameObject projectile = bulletFactory.SpawnBullet(bulletColor, firePoint.position, firePoint.rotation);

                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.AddForce(firePoint.forward * projectileForce, ForceMode.Impulse);

                Destroy(projectile, destroyDelay);

                nextShotTime = Time.time + timeBetweenShots;
            }
        }
    }
}
