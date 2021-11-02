using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BartenderStates : MonoBehaviour
{
    
    // This script observers variable using variable name in INK script
    //checks if variable changes at any point during dialogue then calls method from Game Manager
    public void Whiskey()
    {
        DialogueManager.instance.currentStory.ObserveVariable("isDrunk", LoadDrunk);
    }

    private void LoadDrunk(string variableName, object newValue)
    {
        GameManager.instance.isDrunk = true;
    }

   
}
