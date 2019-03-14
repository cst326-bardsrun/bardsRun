using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    public float BeatTempo;

    private float speed = 5f;
    private GameManager gameManager;
    private Transform platTransform;

    

	// Use this for initialization
	void Start () {
        platTransform = gameObject.transform;
        gameManager = FindObjectOfType<GameManager>();
        BeatTempo = gameManager.getTempo() / 60f;
       
	}


    private void FixedUpdate()
    {
        platTransform.position -= new Vector3(BeatTempo*speed, 0f, 0f) * Time.deltaTime;
    }
}
