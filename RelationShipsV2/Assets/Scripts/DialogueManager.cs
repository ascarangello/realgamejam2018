using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text nameText;
    public Text DialogueText;

    public GameObject[] choices;
    private Queue<string> sentences;
    public static int index;

	void Start () {
        sentences = new Queue<string>();
	}

    public void StartDialogue (Dialogue dialogue)
    {
        HideAllChoices();

        nameText.text = dialogue.name;
        Debug.Log("Starting conversation with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();

        // 

        // Stops all current animations and starts the next text animation
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    //Types letters one at a time
    IEnumerator TypeSentence (string sentence)
    {
        DialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return null;

        }
    }

    // Gives the player their different choices to respond
    void EndDialogue()
    {
        PresentChoices();
        Debug.Log("End of conversation");   
    }

    public void PresentChoices ()
    {
        choices[index].SetActive(true);
        Debug.Log(index);
    }

    // Hides the all the choices from the player during dialogue where they don't respond
    public void HideAllChoices()
    {
        for (int i = 0; i < choices.Length; i++)
        {
            choices[i].SetActive(false);
        }
    }
}
