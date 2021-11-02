using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteract;
    private Shotgun shotgunScript;

    private void Awake()
    {
        shotgunScript = GetComponent<Shotgun>();
    }
    public void AddHealth()
    {
        PlayerStats.instance.playerHealth += 10;
        Destroy(gameObject);
    }

    public void Ammo()
    {
        shotgunScript.ammoCount += Random.Range(1, 5);
        Destroy(gameObject);
    }
    
    
}
