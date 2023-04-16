/*
 * Lucas Johnson
 * Shooting
 * Assignment 6
 * Handles shooting of bullets
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public List<BulletFactory> bulletFactory = new List<BulletFactory>();
    public Transform firePoint;
    public float projectileForce = 20f;
    public float timeBetweenShots = 0.5f;
    public float destroyDelay = 5f;

    private float nextShotTime;

    // Update is called once per frame
    void Update()
    {
        Shoot(KeyCode.Alpha1, 0);
        Shoot(KeyCode.Alpha2, 1);
        Shoot(KeyCode.Alpha3, 2);
    }

    void Shoot(KeyCode keyCode, int bulletFactoryIndex)
    {
        if (Input.GetKeyDown(keyCode))
        {
            bool canShoot = Time.time > nextShotTime;

            if (canShoot)
            {
                GameObject projectile = bulletFactory[bulletFactoryIndex].CreateBullet(firePoint.position, firePoint.rotation);

                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.AddForce(firePoint.forward * projectileForce, ForceMode.Impulse);

                Destroy(projectile, destroyDelay);

                nextShotTime = Time.time + timeBetweenShots;
            }
        }
    }
}
