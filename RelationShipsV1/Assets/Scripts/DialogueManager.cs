using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

    public GameObject[] choices;
    private Queue<string> sentences;
    public static int index;

	void Start () {
        sentences = new Queue<string>();
	}

    public void StartDialogue (Dialogue dialogue)
    {
        HideAllChoices();

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
        Debug.Log(sentence);
    }

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
    public void HideAllChoices()
    {
        for (int i = 0; i < choices.Length; i++)
        {
            choices[i].SetActive(false);
        }
    }
}
