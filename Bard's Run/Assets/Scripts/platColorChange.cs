using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platColorChange : MonoBehaviour {
    Material platMat; 
	// Use this for initialization
	void Start () {
        platMat = GetComponent<Renderer>().material;
        Color newColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        platMat.SetColor("_EmissionColor", newColor);
        platMat.color = newColor;       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
