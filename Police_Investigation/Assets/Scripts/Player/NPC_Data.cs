using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "TYPE NPC NAME HERE", menuName = "NPC Dialogue Data")]
    public class NPC_Data : ScriptableObject
    {
        public new string name;
        public bool playerInRange;
        public float maxRange = 5f;
        public TextAsset inkJSON;
        
        //we use this index to call npc specific functions in NPC_Dialogue script
        //make sure each NPC index is unique to avoid calling func more than once
        public int Index;
    }
}