using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    FMODUnity.StudioEventEmitter emitter;

    [SerializeField]
    float delay;
    void Start()
    {
        InvokeRepeating("Play", delay, 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {
        emitter.Play();
    }
}
