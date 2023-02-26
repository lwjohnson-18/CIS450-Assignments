/*
 * Lucas Johnson
 * PlayerController
 * Assignment 6
 * Controls the Player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float xInput = Input.GetAxis("Horizontal");

        // Get where we currently are
        Vector3 newPos = transform.position;

        // Change x position
        newPos.x += xInput * Time.deltaTime * speed;

        // Clamp Y-Axis
        newPos.x = Mathf.Clamp(newPos.x, -9, 9);

        // Update Paddle's Position
        transform.position = newPos;
    }
}
