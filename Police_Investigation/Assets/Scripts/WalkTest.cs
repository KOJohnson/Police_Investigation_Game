using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTest : MonoBehaviour
{
    public Animator animator;
    private Rigidbody _rb;
    public float speed = 3;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (_rb.velocity.y < -0.5)
        {
            Destroy(gameObject);
        }

        while (true)
        {
            animator.Play("DrunkWalk");
            transform.position += transform.forward * (speed * Time.deltaTime);
            return;
        }
        
    }
}
