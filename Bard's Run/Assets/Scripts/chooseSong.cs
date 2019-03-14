using System.Collections;
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
        lepre = GameObject.Find("lepreText").GetComponent<TextMeshProUGUI>();
        tav = GameObject.Find("medievalText").GetComponent<TextMeshProUGUI>();
        medi = GameObject.Find("tavernText").GetComponent<TextMeshProUGUI>();
    }

    public void Lepre()
    {
        // for testing Debug.Log(lepre.text);

        gameManager.SetSong(lepre.text,120);
        PlayGame();

    }

    public void medieval()
    {

        gameManager.SetSong(medi.text, 110);
        PlayGame();
    }

    public void tavern()
    {
        // for testing Debug.Log(tav.text);
        gameManager.SetSong(tav.text, 108);
        PlayGame();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }
}
