using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int books = 0;

    [SerializeField] private Text booksText;
    [SerializeField] private AudioSource bookCaughtSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Book"))
        {
            bookCaughtSound.Play();
            Destroy(collision.gameObject);
            books++;
            PlayerPrefs.SetInt("player_book_curr", books);
            booksText.text = "Books: " + books;
        }

        if (collision.gameObject.CompareTag("Cherry"))
        {
            bookCaughtSound.Play();
            Destroy(collision.gameObject);
            books++;
            PlayerPrefs.SetInt("player_book_curr", books);
            booksText.text = "Books: " + books;

            Debug.Log("GO GIRL!");
            PlayerPrefs.SetInt("special_win", 1);
        }
    }
}
