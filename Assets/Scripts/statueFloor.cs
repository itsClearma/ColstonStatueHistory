using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class statueFloor : MonoBehaviour
{
    private float PreFabYearStat;
    public GameObject fallenStatue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PreFabYearStat = GetComponentInParent<podiumTopScript>().getPreFabYear();
        fallenStatue.SetActive(true);
        Debug.Log("statue floor code is inactive, preFabYear is: "+PreFabYearStat);
    }

    // Update is called once per frame
    void Update()
    {
        PreFabYearStat = GetComponentInParent<podiumTopScript>().getPreFabYear();
    }

    public void updateFloor(float PreFabYearStat)
    {   
        if (PreFabYearStat >= 2020)
        {
            fallenStatue.SetActive(true);
            Debug.Log("statue floor code is active, preFabYear is: "+PreFabYearStat);
        }
        else
        {
            fallenStatue.SetActive(false);
            Debug.Log("statue floor code is inactive, preFabYear is: "+PreFabYearStat);
        }
    }

}
