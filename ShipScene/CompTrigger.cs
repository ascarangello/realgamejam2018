using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompTrigger : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        Debug.Log("YOU HIT COMPUTER BEEP BORP");
    }
}
