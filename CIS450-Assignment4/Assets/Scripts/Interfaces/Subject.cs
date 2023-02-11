/*
 * Lucas Johnson
 * Subject
 * Assignment 4
 * Interface for subject classes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
{
    void RegisterObserver(Observer o);

    void RemoveObserver(Observer o);

    void TakeDamage();
}
