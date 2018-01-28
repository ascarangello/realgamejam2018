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

    public void OpenTestChat()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadNerd();
    }

    public void BackToDesktop()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        scenes.LoadDesktop();
    }

}
