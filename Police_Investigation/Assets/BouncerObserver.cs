using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncerObserver : MonoBehaviour
{
    public void OpenDoor()
    {
        DialogueManager.instance.currentStory.ObserveVariable("openDoor", Observer);
    }

    private void Observer(string variableName, object newValue)
    {
        GameManager.instance.openDoor = true;
    }
    
}
