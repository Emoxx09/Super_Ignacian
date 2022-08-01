using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    private bool levelCompleted = false;
    public float finishTime;
    [SerializeField] private Text booksText;
    [SerializeField] private AudioSource winSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            if (PlayerPrefs.GetInt("special_win") == 1)
            {
                winSound.Play();
                Debug.Log("SPECIAL HERE" + PlayerPrefs.GetInt("special_win"));
                levelCompleted = true;
                Invoke("CompleteLevel", 2f);
            }
            else
            {
                winSound.Play();
                Debug.Log("HERE" + PlayerPrefs.GetInt("special_win"));
                levelCompleted = true;
                Invoke("CompleteLevel", 2f);
            }
            
        }
    }

    private void CompleteLevel()
    {
        if (PlayerPrefs.GetInt("special_win") == 1)
        {
            PlayerPrefs.SetString("player_main_message", "THANK YOU SO MUCH!");
            PlayerPrefs.SetString("player_time", "You spent a lot of time trying to figure that out!");
            PlayerPrefs.SetString("player_book", "I appreciate you <3 send me a pm on fb with a screenshot to get your prize");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            string timeSpent = "Time: " + System.Math.Round(Time.timeSinceLevelLoad, 2);
            string booksCaught = booksText.text;
            PlayerPrefs.SetString("player_main_message", "AWESOME!");
            PlayerPrefs.SetString("player_time", timeSpent);
            PlayerPrefs.SetString("player_book", booksCaught);
            Debug.Log(timeSpent + booksCaught);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
