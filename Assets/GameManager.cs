using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public TMP_Text finalScoreText;
    public Button startButton;

    public int score = 0;
    public float gameTime = 30f; // seconds
    private float timeLeft;
    private bool gameStarted = false;

    void Start()
    {
        // Hide final score initially
        finalScoreText.gameObject.SetActive(false);
        startButton.onClick.AddListener(StartGame);
    }

    void Update()
    {
        if (!gameStarted) return;

        timeLeft -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.CeilToInt(timeLeft).ToString();

        if (timeLeft <= 0f)
        {
            EndGame();
        }
    }

    public void StartGame()
    {
        gameStarted = true;
        timeLeft = gameTime;
        score = 0;
        scoreText.text = "Score: 0";
        finalScoreText.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    void EndGame()
    {
        gameStarted = false;
        finalScoreText.text = "Final Score: " + score;
        finalScoreText.gameObject.SetActive(true);
        startButton.gameObject.SetActive(true);
    }
}
