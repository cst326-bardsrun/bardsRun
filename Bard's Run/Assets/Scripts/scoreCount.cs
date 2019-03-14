using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreCount : MonoBehaviour {

    public TextMeshProUGUI scoreText;
    GameManager gameManager;
    // Use this for initialization
    
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = "Score: " + gameManager.getScore().ToString();
	}
}
