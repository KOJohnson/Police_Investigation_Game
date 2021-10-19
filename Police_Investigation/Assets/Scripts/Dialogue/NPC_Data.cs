using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPC Dialogue Data", menuName = "NPC Data")]
public class NPC_Data : ScriptableObject
{
    public string npcName;
    public TextAsset inkJSON;
    public bool playerInRange;
    public float maxRange = 5f;
    

}
