﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class chooseSong : MonoBehaviour {

    private GameManager gameManager;
    public TextMeshProUGUI lepre, tav, medi;
   

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        lepre = GameObject.Find("lepreButton").GetComponent<TextMeshProUGUI>();
        tav = GameObject.Find("medievalText").GetComponent<TextMeshProUGUI>();
        medi = GameObject.Find("tavernText").GetComponent<TextMeshProUGUI>();
    }

    public void Lepre()
    {
        gameManager.SetSong(lepre.text,109,108);
        PlayGame();
    }

    public void medieval()
    {

        gameManager.SetSong(medi.text, 120, 275);
        PlayGame();
    }

    public void tavern()
    {
        gameManager.SetSong(tav.text, 120, 207);
        PlayGame();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}