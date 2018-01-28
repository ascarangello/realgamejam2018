using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompTrigger : MonoBehaviour {

    public GameManager scenes;

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        GameManager.playerByComp = true;
        scenes.LoadDesktop();
    }
}
