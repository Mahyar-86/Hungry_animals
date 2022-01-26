using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class PuseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject puseMenuUI;
    
    public AudioMixer audioMixer;
    // Update is called once per frame

    public void Resume()
    {
        puseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused=false;   
    }

    public void Pase()
    {
        puseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused=true;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume",volume);
    }
    
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
