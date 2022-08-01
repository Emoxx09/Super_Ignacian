using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterPrefs : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("special_win", 0);
    }

}
