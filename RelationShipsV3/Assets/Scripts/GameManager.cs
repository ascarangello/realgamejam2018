using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static bool playerByComp;

    public static int nerdLove;
    public static int jockLove;
    public static int prepLove;
    public static int gothLove;

    public static int day;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        nerdLove = 0;
        jockLove = 0;
        prepLove = 0;
        gothLove = 0;

        day = 1;
    }

    public void LoadShip()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadDesktop()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadNerd()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGoth()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadJock()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadPrep()
    {
        SceneManager.LoadScene(6);
    }
}
