using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CongratsTrigger : MonoBehaviour {

    [SerializeField] private SpriteRenderer dialogue;
    [SerializeField] private AudioSource messagePop;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int books = PlayerPrefs.GetInt("player_book_curr");
            if (books >= 8)
            {
                dialogue.enabled = true;
                messagePop.Play();
            }
            else
            {
                Debug.Log(PlayerPrefs.GetInt("player_book_curr"));
            }
        }
    }
}
