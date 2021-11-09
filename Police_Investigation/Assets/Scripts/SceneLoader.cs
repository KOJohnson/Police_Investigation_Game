using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]private GameObject uiFadeOut;
    [SerializeField]private GameObject uiFadeIn;

    private Scene _scene;
    private void Awake()
    {
        uiFadeIn.SetActive(true);
        _scene = SceneManager.GetActiveScene();
    }

    public void Update()
    {
        if (CustomPlayerInputManager.instance.spacebarPressed && _scene.buildIndex == 0)
        {
            StartCoroutine(LoadCandyLand());
        }
        
        if (CustomPlayerInputManager.instance.spacebarPressed && _scene.buildIndex == 2)
        {
            StartCoroutine(LoadMainMenu());
        }
        
        if (CustomPlayerInputManager.instance.spacebarPressed && _scene.buildIndex == 4)
        {
            StartCoroutine(LoadMainMenu());
        }
        
        if (CustomPlayerInputManager.instance.spacebarPressed && _scene.buildIndex == 6)
        {
            StartCoroutine(LoadMainMenu());
        }
        
        
        IEnumerator LoadCandyLand()
        {
            uiFadeOut.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Candyland Scene");
        }
        
        IEnumerator LoadMainMenu()
        {
            uiFadeOut.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("MainMenuHouse");
        }
        
    }
}
