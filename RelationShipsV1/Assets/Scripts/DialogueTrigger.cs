using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public int jumpToTree;

public void TriggerDialogue ()  {

        DialogueManager.index = jumpToTree;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
