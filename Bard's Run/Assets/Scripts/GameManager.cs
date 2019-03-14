using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    //Other objects we are communicating with.
    private PlatformGenerator generator;
    private GameObject player;

    //GameManager's personal variables
    private static float score;
    private float timeBetweenPlatforms;
    private float spawnPlatTime;
    

    //Values given to us through the main menu
    public static float tempo;
    public float songLength;
    public static string songName;
   

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            songLength = FindObjectOfType<camAudio>().getAudioLength();
            player = GameObject.Find("Player");

            generator = GetComponentInChildren<PlatformGenerator>();
            timeBetweenPlatforms = tempo / 100f;
            spawnPlatTime = timeBetweenPlatforms;

        }
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Main")
        {
            score += 50 * Time.deltaTime;
            songLength -= Time.deltaTime;
            spawnPlatTime -= Time.deltaTime;
            if(songLength <= 0)
            {
                SceneManager.LoadScene("End");
            }
            if (spawnPlatTime <= 0)
            {
                generator.createPlatform();
                spawnPlatTime = timeBetweenPlatforms;
            }
        }
        Debug.Log(score);
    }

    public void addScore(float num)
    {
        score += num;
    }

    public void decrementScore()
    {
        score -= score / 10;
        player.GetComponent<Player>().resetPosition();
    }

    public float getTempo() {
        return tempo;
    }

    public void SetSong(string newSongName, float newTempo)
    {
        songName = newSongName;
        tempo = newTempo;
    }

    public float getScore()
    {
        return score;
    }
    
    
    public string getAudioName()
    {
        return songName;
    }
    
}
