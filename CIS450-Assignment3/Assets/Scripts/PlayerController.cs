/*
 * Lucas Johnson
 * PlayerController
 * Assignment 3
 * Controls the Player
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, Subject
{
    [SerializeField] float speed = 10f;

    private List<Observer> observers = new List<Observer>();

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
        newPos.x = Mathf.Clamp(newPos.x, -7, 7);

        // Update Paddle's Position
        transform.position = newPos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Object"))
        {
            TakeDamage();
        }
    }

    public void RegisterObserver(Observer o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(Observer o)
    {
        observers.Remove(o);
    }

    public void TakeDamage()
    {
        if(observers.Count <= 0)
        {
            return;
        }

        foreach (Observer observer in observers)
        {
            observer.UpdateLives();
        }
    }
}
