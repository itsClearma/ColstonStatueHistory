using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class statueStand : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateStand(float value)
    {   
        if (value < 2020)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}
