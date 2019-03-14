using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndSceneScore : MonoBehaviour {
    public TextMeshPro scoreText;
    GameManager gameManager;
    // Use this for initialization

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        scoreText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + gameManager.getScore().ToString();
    }
}
