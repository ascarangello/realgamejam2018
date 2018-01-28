using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedTrigger : MonoBehaviour {

    public GameManager scenes;
    private System.Timers.Timer timer = new System.Timers.Timer();

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        Debug.Log("YOU SLEEP");
        timer.Elapsed += OnTimer;
        timer.Interval = 2000;
        timer.AutoReset = false;
        timer.Enabled = true;
        PlayerController.sleeping = true;
        collidedObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        collidedObject.GetComponent<Transform>().position = GetComponent<Transform>().position;
        GameManager.playerByComp = false;
    }

    private void OnTimer(object source, System.Timers.ElapsedEventArgs e)
    {
        PlayerController.sleeping = false;
    }
}
