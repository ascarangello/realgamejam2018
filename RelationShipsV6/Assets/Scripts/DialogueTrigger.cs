using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;
    public int jumpToTree;

    public int jockAffection;
    public int nerdAffection;
    public int prepAffection;
    public int gothAffection;

    public void TriggerDialogue ()  {

        GameManager.nerdLove = GameManager.nerdLove+nerdAffection;
        GameManager.jockLove = GameManager.jockLove + jockAffection;
        GameManager.prepLove = GameManager.prepLove + prepAffection;
        GameManager.gothLove = GameManager.gothLove + gothAffection;
        DialogueManager.index = jumpToTree;
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
