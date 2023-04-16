/*
 * Lucas Johnson
 * TitleDisplayController
 * Assignment 6
 * Controls the main text display
 */
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleDisplayController : MonoBehaviour
{
    private TextMeshProUGUI titleText;

    private void Awake()
    {
        titleText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateTitleText(string newTitle)
    {
        titleText.text = newTitle;
    }
}
