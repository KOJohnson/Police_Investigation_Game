using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "TYPE NPC NAME HERE", menuName = "NPC Dialogue Data")]
    public class NPC_Data : ScriptableObject
    {
        public new string name;
        public bool playerInRange;
        public float maxRange = 5f;
        public TextAsset INKjSON;
    }
}