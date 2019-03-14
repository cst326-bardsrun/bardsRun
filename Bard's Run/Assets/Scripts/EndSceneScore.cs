using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneScore : MonoBehaviour {

    GameManager gameManager;
    Text scoreText;

	// Use this for initialization
	void Start () {
        gameManager = FindObjectOfType<GameManager>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();

        scoreText.text = "0";
        //scoreText.text = gameManager.getScore().ToString();
	}
}
