using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsabelObserver : MonoBehaviour
{
    public void HasGirl()
    {
        DialogueManager.instance.currentStory.ObserveVariable("hasGirl", Observer);
    }

    private void Observer(string variableName, object newValue)
    {
        GameManager.instance.hasGirl = true;
    }
}
