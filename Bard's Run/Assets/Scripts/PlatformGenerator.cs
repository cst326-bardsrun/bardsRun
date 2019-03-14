using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

    public GameObject thePlatform;
    public Vector3 generationPoint;
    private float distanceBetween;
    private float platformLevel;

    private float levelMin = -3f;
    private float levelMax = 2f;
    private float platformWidth;
    

	// Use this for initialization
	void Start () {
        platformWidth = thePlatform.GetComponent<BoxCollider>().size.x;
        generationPoint = GameObject.Find("PlatformGenerationPoint").transform.position;
	}
	
	// Update is called once per frame
    public void createPlatform () {
        
        //platform instantiation 
        platformLevel = Random.Range(levelMin, levelMax);
        Vector3 newPlatPos = new Vector3(generationPoint.x + platformWidth, generationPoint.y + platformLevel, generationPoint.z);

        Instantiate(thePlatform, newPlatPos, transform.rotation);
        
    }
}
