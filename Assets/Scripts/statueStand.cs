using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class statueStand : MonoBehaviour
{
    private float PreFabYearStat;
    public GameObject uprightStatue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PreFabYearStat = GetComponentInParent<podiumTopScript>().getPreFabYear();
        uprightStatue.SetActive(true);
        Debug.Log("statue stand code is active, preFabYear is: "+PreFabYearStat);
    }

    // Update is called once per frame
    void Update()
    {
        PreFabYearStat = GetComponentInParent<podiumTopScript>().getPreFabYear();
        if (PreFabYearStat < 2020)
        {
            uprightStatue.SetActive(true);
        }
        else
        {
            uprightStatue.SetActive(false);
        }

    }

    public void updateStand(float PreFabYearStat)
    {   
        
    }

}
