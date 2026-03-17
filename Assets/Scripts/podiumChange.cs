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

    //private GameObject PodiumTop;

    private StatueModels;
    private StatueFloor;
    private StatueStand;

    private void Reset()
    {
        StatueFloor = StatueModels.GetComponentInChildren<StatueFloor>();
        StatueStand = StatueModels.GetComponentInChildren<StatueStand>();
    }

    public void updatePodium(float value)
    {   
        if (value >= 2020)
        {
            StatueStand.SetActive(false);
            StatueFloor.SetActive(true);
            //ransform.position = new Vector3(0.0f, 0.0f, 1.5f);
            //transform.Rotate(0, 0, 90);
        }
        else
        {
            StatueStand.SetActive(true);
            StatueFloor.SetActive(false);
            //transform.position = new Vector3(0.0f, 0.8f, 1.5f);
            //transform.Rotate(0, 0, 0);
        }
        //transform.localScale = new Vector3(0.3f, (value/5000), 0.3f);
    }

}
