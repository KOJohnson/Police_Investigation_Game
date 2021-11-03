using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]private GameObject uiFadeOut;
    [SerializeField]private GameObject uiFadeIn;

    private void Awake()
    {
        uiFadeIn.SetActive(true);
    }

    public void Update()
    {
        if (CustomPlayerInputManager.instance.spacebarPressed)
        {

            StartCoroutine(LoadCandyLand());
        }
        
        
        IEnumerator LoadCandyLand()
        {
            uiFadeOut.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Candyland Scene");
        }
        
    }
}
