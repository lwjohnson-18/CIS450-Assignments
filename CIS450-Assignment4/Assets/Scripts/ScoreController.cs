using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] PlayerController subject;
    [SerializeField] int currentScore;

    private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        currentScore = 0;
    }
    public void UpdateScore(int pointsToAdd)
    {
        currentScore += pointsToAdd;
        scoreText.text = currentScore.ToString();
    }
}
