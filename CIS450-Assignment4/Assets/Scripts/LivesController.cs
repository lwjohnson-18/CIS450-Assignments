/*
 * Lucas Johnson
 * LivesController
 * Assignment 4
 * Controls Lives System
 */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesController : MonoBehaviour, Observer
{
    [SerializeField] PlayerController subject;
    [SerializeField] int maxLives = 3;
    [SerializeField] int currentLives;

    private TextMeshProUGUI livesText;

    private void OnEnable()
    {
        subject.RegisterObserver(this);
    }

    private void OnDisable()
    {
        subject.RemoveObserver(this);
    }


    private void Start()
    {
        livesText = GetComponent<TextMeshProUGUI>();
        currentLives = maxLives;
    }
    public void UpdateLives()
    {
        currentLives--;

        if(currentLives < 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            livesText.text = "Lives: " + currentLives;
        }
    }
}
