using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class podiumTopScript : MonoBehaviour
{
    public GameObject PodiumTop;
    public GameObject allChildren[];
    public float PreFabYear;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        allChildren = new GameObject[parentObject.transform.childCount];

        for (int = 0; i < allChildren.Length; i++)
        {
            allChildren[i] = parentObject.transform.GetChild(i).gameObject;
        }

        ColstonStand.SetActive(true);
        ColstonFloor.SetActive(false);
    }

    //Update is called once per frame
    void Update()
    {

    }
    
    public void YearUpdate()
    {
        if (PreFabYear < 2020)
        {
            ColstonStand.SetActive(true);
            ColstonFloor.SetActive(false);
        }
        else
        {
            ColstonStand.SetActive(false);
            ColstonFloor.SetActive(true);
        }
    }

    public void YearChange(float value)
    {
        PreFabYear = value;
        Debug.Log("PreFabYear: "+PreFabYear);
    }
}
