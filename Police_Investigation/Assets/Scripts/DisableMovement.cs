using UnityEngine;

public class DisableMovement : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            col.GetComponent<Movement>().enabled = false;
            col.GetComponent<Pathing>().enabled = true;
        }
    }
}
