using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Other objects we are communicating with.
    private PlatformGenerator generator;
    private GameObject player;

    //GameManager's personal variables
    private float score;
    private float timeBetweenPlatforms;
    private float spawnPlatTime;


    //Values given to us through the main menu
    public float tempo;
    public float songLength;
    

    private void Start()
    {
        player = FindObjectOfType<Player>().gameObject;
        generator = FindObjectOfType<PlatformGenerator>();
        timeBetweenPlatforms = tempo / 60f;
        spawnPlatTime = timeBetweenPlatforms;
    }

    private void Update()
    {
        score += 50 * Time.deltaTime;
        spawnPlatTime -= Time.deltaTime;

        if(spawnPlatTime <= 0)
        {
            generator.createPlatform();
            spawnPlatTime = timeBetweenPlatforms;
        }
    }

    public void addScore(float num)
    {
        score = num;
    }

    public void decrementScore()
    {
        score -= score / 10;
        player.GetComponent<Player>().resetPosition();
    }

    public float getTempo() {
        return this.tempo;
    }

}
