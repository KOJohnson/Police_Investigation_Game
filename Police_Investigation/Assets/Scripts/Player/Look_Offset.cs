using UnityEngine;

public class Look_Offset : MonoBehaviour
{
    private Vector3 lookOffset;
    [SerializeField] private GameObject objectToFollow;
    [SerializeField] private float offsetSpeed;
    

    void Start()
    {
        // objectToFollow = Camera.main.gameObject;
        lookOffset = transform.position - objectToFollow.transform.position;
    }
    
    void Update()
    {
        transform.position = objectToFollow.transform.position + lookOffset;
        transform.rotation = Quaternion.Slerp(transform.rotation, objectToFollow.transform.rotation, offsetSpeed * Time.deltaTime);
    }
}
