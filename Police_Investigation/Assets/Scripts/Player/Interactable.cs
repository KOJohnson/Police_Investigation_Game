using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteract;
    public void AddHealth()
    {
        PlayerStats.instance.playerHealth += 10;
        Destroy(gameObject);
    }
}
