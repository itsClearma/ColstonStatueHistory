using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class podiumTopScript : MonoBehaviour
{
    //[SerializeField] public GameObject ColstonStand;
    //[SerializeField] public GameObject ColstonFloor;

    public float PreFabYear;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColstonStand.SetActive(true);
        //ColstonFloor.SetActive(false);
    }

    //Update is called once per frame
    void Update()
    {
        
    }

    public void YearChange(float value)
    {
        PreFabYear = value;

        if (PreFabYear < 2020)//standing
        {
            //ColstonStand.SetActive(true);
            //ColstonFloor.SetActive(false);
            Debug.Log("Statue standing");
        }
        else//fallen
        {
            //ColstonStand.SetActive(false);
            //ColstonFloor.SetActive(true);
            Debug.Log("Statue fallen");
        }
    }

    public float getPreFabYear()
    {
        return PreFabYear;
    }
}
