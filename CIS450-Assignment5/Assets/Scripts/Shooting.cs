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
    public GameObject[] projectiles;
    public Transform firePoint;
    public float projectileForce = 20f;
    public float timeBetweenShots = 0.5f;
    public float destroyDelay = 5f;

    private float nextShotTime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            bool canShoot = Time.time > nextShotTime;

            if (canShoot)
            {
                GameObject projectile = Instantiate(projectiles[0], firePoint.position, firePoint.rotation);

                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.AddForce(firePoint.forward * projectileForce, ForceMode.Impulse);

                Destroy(projectile, destroyDelay);

                nextShotTime = Time.time + timeBetweenShots;
            }
        }
    }
}
