using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public Slider slider;

    public Gradient gradient;

    public Image fill;
    
    public Text scoreText;

    private String a;

    public GameObject gameOverObject;
    public GameObject planGameObject;
    public GameObject player;
    public GameObject food;
    
    public AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "game")
        {
            slider.maxValue = 10;
            fill.color = gradient.Evaluate(1f);
        }
    }

    public void AddLives(int value)
    {
        slider.value += value;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        if (slider.value <= 0)
        {
            GameOver();
        }
    }
    public void AddScore(int value)
    {
        score += value;
    }
    
    public void PlayScore()
    {
        a = score.ToString();
        scoreText.text = $"Score: {a}";
    }

    public void Update()
    {
        if(SceneManager.GetActiveScene().name=="Game")
        {
            PlayScore();
        }
    }

    public void Tryagain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        planGameObject.SetActive(true);
        gameOverObject.SetActive(true);
        player.SetActive(false);
        food.SetActive(false);
    }
}
