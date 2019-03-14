using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camAudio : MonoBehaviour {
    //public AudioSource songSource;
    private GameManager gameManager;
    AudioSource songSource;

    void Awake () {
        
        songSource = GetComponent<AudioSource>();
        gameManager = FindObjectOfType<GameManager>();
        string songName = gameManager.getAudioName();

        //grabbing audio source for use and play
        songSource.clip = Resources.Load<AudioClip>("Music/"+songName);
        songSource.Play();
        
        
    }
	
    public float getAudioLength()
    {
        return songSource.clip.length;
    }
}
