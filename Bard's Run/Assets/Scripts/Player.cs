using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float jumpPower;

    private GameManager gameManager;
    private Rigidbody rb;
    [SerializeField] private bool isGrounded;

	// Use this for initialization
	void Start () {
        gameManager = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody>();
        isGrounded = false;
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, jumpPower * 5, 0));
        }

        if(transform.position.x < -5f)
        {
            gameManager.decrementScore();
        }
	}

    public void resetPosition()
    {
        transform.position = new Vector3(0f, 5f, 0f);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground" && !(isGrounded) )
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground" && isGrounded)
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ScoreBox")
        {
            gameManager.addScore(100);
        }
    }

}
