using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class particleTrigger : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void Reset()
    // {
    //     FX = PodiumTop.GetComponent<ParticleSystem>();
    // }

    public void updateParticle(float value)
    {   
        if (value == 1985 || value == 2020)
        {
            //particle.Play();
            Debug.Log("on");
        } else {
            //particle.Stop();
            Debug.Log("off");
        }
    }

}
