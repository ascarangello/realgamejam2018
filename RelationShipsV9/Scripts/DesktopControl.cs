using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopControl : MonoBehaviour {

    public GameManager scenes;

    public void ExitDesktop()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadShip();
    }

    public void BackToDesktop()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadShip();
    }

    public void edgyPath()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadGoth1();
    }

    public void prepPath()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadPrep1();
    }

    public void jockPath()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadJock1();
    }
    public void nerdPath()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadNerd1();
    }
}
