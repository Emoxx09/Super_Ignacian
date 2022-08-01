using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button pausePlay;
    [SerializeField] private Sprite pauseSprite;
    [SerializeField] private Sprite playSprite;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void About()
    {
        SceneManager.LoadScene(3);
    }

    public void PausePlay()
    {
        if (pausePlay.image.sprite == pauseSprite)
        {
            Time.timeScale = 0;
            pausePlay.image.sprite = playSprite;
        }
        else
        {
            Time.timeScale = 1;
            pausePlay.image.sprite = pauseSprite;
        }
    }
}
