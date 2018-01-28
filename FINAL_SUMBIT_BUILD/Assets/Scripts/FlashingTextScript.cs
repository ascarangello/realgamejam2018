using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FlashingTextScript : MonoBehaviour
{
    public GameManager scenes;
    Text flashingText;

    void Start()
    {
        //get the Text component
        flashingText = GetComponent<Text>();
        //Call coroutine BlinkText on Start
        StartCoroutine(BlinkText());
    }

    private void Update()
    {
        if(Input.GetButton("space"))
            scenes.LoadShip();
    }

    //function to blink the text 
    public IEnumerator BlinkText()
    {
        //blink it forever. You can set a terminating condition depending upon your requirement
        while (true)
        {
            //set the Text's text to blank
            flashingText.text = "";
            //display blank text for 0.5 seconds
            yield return new WaitForSeconds(.5f);
            //display this text for the next 0.5 seconds
            flashingText.text = "Press spacebar to begin";
            yield return new WaitForSeconds(.75f);
        }
    }

}
