using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class podiumChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private GameObject PodiumTop;
    public int yearNumber;

    public void updatePodium(float value)
    {   
        if (value >= 2020)
        {
            transform.position = new Vector3(0, 0, 3/2);
            transform.Rotate(0, 0, 90);
        }
        else
        {
            transform.position = new Vector3(0, 1, 3/2);
            //transform.Rotate(0, 0, 0);
        }
        transform.localScale = new Vector3(0.3f, (value/5000), 0.3f);
    }

}
