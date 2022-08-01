using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoresGenerator : MonoBehaviour
{
    [SerializeField] Text mainMessage;
    [SerializeField] Text timeSpent;
    [SerializeField] Text booksCaught;

    void Start()
    {
        if (PlayerPrefs.GetInt("special_win") == 1)
        {
            mainMessage.fontSize = 29;
            timeSpent.fontSize = 20;
            booksCaught.fontSize = 17;
        }
        mainMessage.text = PlayerPrefs.GetString("player_main_message");
        timeSpent.text = PlayerPrefs.GetString("player_time");
        booksCaught.text = PlayerPrefs.GetString("player_book");
    }

}
