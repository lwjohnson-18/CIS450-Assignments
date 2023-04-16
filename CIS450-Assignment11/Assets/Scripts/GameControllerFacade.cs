/*
 * Lucas Johnson
 * GameControllerFacade
 * Assignment 11
 * Controls the general game flow
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerFacade : MonoBehaviour
{
    public TitleDisplayController titleDisplayController;
    public PlayerController playerController;
    public ObjectSpawnerController objectSpawnerController;

    private bool gameStarted = false;
    private bool gamePaused = false;

    private void Update()
    {
        if(!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            PauseUnpauseGame();
        }
    }

    public void StartGame()
    {
        titleDisplayController.UpdateTitleText("");
        playerController.SetCanMove(true);
        objectSpawnerController.SetActivation(true);
    }

    public void PauseUnpauseGame()
    {
        if(!gamePaused)
        {
            titleDisplayController.UpdateTitleText("Paused");
            playerController.SetCanMove(false);
            objectSpawnerController.SetActivation(false);
        }
        else
        {
            titleDisplayController.UpdateTitleText("");
            playerController.SetCanMove(true);
            objectSpawnerController.SetActivation(true);
        }

        gamePaused = !gamePaused;
    }
}
