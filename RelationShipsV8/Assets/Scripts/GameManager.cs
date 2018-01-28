using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static bool playerByComp;
    public static bool firstComp;
    public static bool postPreGC;

    // 1 = goth, 2 = prep, 3 = jock, 4 = nerd
    public static int path;

    public static int day;    

    public static int nerdLove;
    public static int jockLove;
    public static int prepLove;
    public static int gothLove;

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

        firstComp = true;
        postPreGC = false;
        day = 0;
    }

    public void LoadShip()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadPreBranchGC()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadDesktop()
    {
        SceneManager.LoadScene(3);
    }

    // Edgy path
    public void LoadGoth1()
    {
        path = 1;
        SceneManager.LoadScene(7);
    }
    public void LoadGoth2()
    {
        day += 1;
        SceneManager.LoadScene(8);
    }
    public void LoadGoth3()
    {
        SceneManager.LoadScene(9);
    }

    // Prep path
    public void LoadPrep1()
    {
        path = 2;
        SceneManager.LoadScene(4);
    }
    public void LoadPrep2()
    {
        SceneManager.LoadScene(5);
    }
    public void LoadPrep3()
    {
        SceneManager.LoadScene(6);
    }

    // Jock path
    public void LoadJock1()
    {
        SceneManager.LoadScene(10);
    }
    public void LoadJock2()
    {
        SceneManager.LoadScene(11);
    }
    public void LoadJock3()
    {
        SceneManager.LoadScene(12);
    }

    // Nerd path
    public void LoadNerd1()
    {

    }
    public void LoadNerd2()
    {

    }
    public void LoadNerd3()
    {

    }

}
