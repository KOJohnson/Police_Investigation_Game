using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

public class Interactions : MonoBehaviour
{  
    [SerializeField] LayerMask interactableLayer;
    [SerializeField] private int maxDistance = 3;

    // Update is called once per frame
    void Update()
    {
        if (CustomPlayerInputManager.instance.fPressed)
        {
            RayCastInteract();
        }
    }

    private void RayCastInteract()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit Hit;
        if (Physics.Raycast(ray, out Hit, maxDistance, interactableLayer))
        {
            Debug.Log(Hit.transform.name);
        }
    }
}
