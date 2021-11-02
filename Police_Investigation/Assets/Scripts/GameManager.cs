using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isDrunk;
    public bool hasKey;
    
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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDrunk) StartCoroutine(LoadDrunkScene());
    }


    private IEnumerator LoadDrunkScene()
    {
        uiFadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Drunk Ending");
    }
    
    
    
}
