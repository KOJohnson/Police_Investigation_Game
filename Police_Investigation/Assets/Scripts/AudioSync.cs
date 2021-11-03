using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSync : MonoBehaviour
{
    [SerializeField] private AudioSource master;
    // [SerializeField] private AudioSource slave;
    // [SerializeField] private AudioSource slave2;
    // [SerializeField] private AudioSource slave3;
    [SerializeField] private AudioSource[] slaves;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (true)
        {
            foreach (var slave in slaves)
            {
                slave.timeSamples = master.timeSamples;
                return;
            }
        }
        
    }
}
