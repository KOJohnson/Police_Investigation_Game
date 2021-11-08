using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    
    public bool isDrunk;
    public bool hasKey;
    public bool hasGirl;
    public bool playerDead;
    
    public int enemyKilled;
    
    [SerializeField]private GameObject uiFadeIn;
    [SerializeField]private GameObject uiFadeOut;
    private void Awake()
    {
        if (instance == null) //check if instance is null
        {
            instance = this; // assign instance to this instance of the class
        }
        else if (instance != this) //check if this instance has already been assigned elsewhere
        {
            Destroy(gameObject); //destroy manager if one already exists in the scene
        }
        
        uiFadeIn.SetActive(true); //enable ui element for smooth fade in
    }
    
    void Update()
    {
        if (isDrunk && !DialogueManager.instance.dialogueIsPlaying) StartCoroutine(LoadDrunkScene());
        
        if (playerDead && !DialogueManager.instance.dialogueIsPlaying) StartCoroutine(LoadDeathScene());
        
        if (hasGirl && !DialogueManager.instance.dialogueIsPlaying) StartCoroutine(LoadRailScene());
    }

    private IEnumerator LoadRailScene()
    {
        uiFadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Candyland Rail Scene");
    }

    private IEnumerator LoadDeathScene()
    {
        uiFadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Death Scene");
    }


    private IEnumerator LoadDrunkScene()
    {
        uiFadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Drunk Ending");

    }
    
    
    
}
