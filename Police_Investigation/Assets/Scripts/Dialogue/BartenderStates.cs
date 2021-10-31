using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BartenderStates : MonoBehaviour
{
    public bool isDrunk;
    
    // This script observers variable using variable name in INK script
    //checks if variable changes at any point during dialogue then calls a method
    public void Whiskey()
    {
        DialogueManager.instance.currentStory.ObserveVariable("isDrunk", LoadDrunk);
    }

    private void LoadDrunk(string variableName, object newValue)
    {
        isDrunk = true;
        StartCoroutine(LoadDrunkScene());

    }

    IEnumerator LoadDrunkScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
