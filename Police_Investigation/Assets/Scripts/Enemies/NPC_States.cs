using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_States : MonoBehaviour
{
    public void KeyCheck()
    {
        DialogueManager.instance.currentStory.ObserveVariable("hasKey", Observer);
    }

    private void Observer(string variableName, object newValue)
    {
        GameManager.instance.hasKey = true;
    }

}
