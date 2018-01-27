using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed;
    public static bool sleeping = false;
    
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");
        if (!sleeping)
        {
            rb.velocity = (new Vector2(xMove * speed, yMove * speed));
        }
	}

}
