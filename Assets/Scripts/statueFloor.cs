using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class statueFloor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateFloor(float value)
    {   
        if (value < 2020)
        {
            gameObject.SetActive(false);
            //transform.position = new Vector3(0.0f, 0.0f, 1.5f);
        }
        else
        {
            //StatueStand.SetActive(true);
            //StatueFloor.SetActive(false);
            gameObject.SetActive(true);
            //transform.position = new Vector3(0.0f, 0.8f, 1.5f);
        }
        //transform.localScale = new Vector3(0.3f, (value/5000), 0.3f);
    }

}
