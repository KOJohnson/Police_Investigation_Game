using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BartenderStates : MonoBehaviour
{
    public bool isDrunk;
    
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
