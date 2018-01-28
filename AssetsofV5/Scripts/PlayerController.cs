using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    
   
    private Rigidbody2D rb;
    public float speed;
    public static bool sleeping = false;
    
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        if (GameManager.playerByComp)
            rb.position = new Vector2(-3.45f, -1.2f);
	}

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
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
