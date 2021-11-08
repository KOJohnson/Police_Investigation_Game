using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteract;
    private Shotgun _shotgunScript;

    private void Awake()
    {
        _shotgunScript = GetComponent<Shotgun>();
    }
    public void AddHealth()
    {
        PlayerStats.instance.currentHealth += 10;
        Destroy(gameObject);
    }

    public void Ammo()
    {
        _shotgunScript.ammoCount += Random.Range(1, 5);
        Destroy(gameObject);
    }

    public void OpenDoor()
    {
        
    }



}
