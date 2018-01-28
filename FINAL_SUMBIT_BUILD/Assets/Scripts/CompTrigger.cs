using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompTrigger : MonoBehaviour {

    public GameManager scenes;

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        GameManager.playerByComp = true;

        if (GameManager.postPreGC)
        {
            GameManager.day = 2;
            GameManager.postPreGC = false;
            scenes.LoadDesktop();
        }

        if (GameManager.firstComp)
        {
            GameManager.postPreGC = true;
            GameManager.firstComp = false;
            scenes.LoadPreBranchGC();
        }
        

        // Goth path
        if(GameManager.path == 1)
        {
            if (GameManager.day == 2)
                scenes.LoadGoth2();
            if (GameManager.day == 3)
                scenes.LoadGoth3();
        }

        // Prep path
        if (GameManager.path == 2)
        {
            if (GameManager.day == 2)
                scenes.LoadPrep2();
            if (GameManager.day == 3)
                scenes.LoadPrep3();
        }

        // Jock path
        if (GameManager.path == 3)
        {
            if (GameManager.day == 2)
                scenes.LoadJock2();
            if (GameManager.day == 3)
                scenes.LoadJock3();
        }

        // Nerd path
        if (GameManager.path == 4)
        {
            if (GameManager.day == 2)
                scenes.LoadNerd2();
            if (GameManager.day == 3)
                scenes.LoadNerd3();
        }
    }
}
