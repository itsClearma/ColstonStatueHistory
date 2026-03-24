using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class particleTrigger : MonoBehaviour
{
    ParticleSystem myPS;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myPS = GetComponent<ParticleSystem>();
    }

    void startParticles(){
        myPS.Play();
        Debug.Log("Play()");
    }

    void stopParticles(){
        myPS.Stop();
        Debug.Log("Stop()");
    }

    void pauseParticles(){
        myPS.Pause();
        Debug.Log("Pause()");
    }

    void clearParticles(){
        myPS.Clear();
        Debug.Log("Clear()");
    }

    void resetParticleSystemTime(){
        myPS.time = 0;
        Debug.Log("Time Reset");
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
        if ((value == 2020) || (value == 1895))
        {
            myPS.Play();
            Invoke("startParticles", 2);
            Debug.Log("particle on");
        } else {
            myPS.Stop();
            myPS.Clear();
            Debug.Log("particle off");
        }
    }

}
