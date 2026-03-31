using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using SimpleJSON;
using TMPro;

public class quotePlacer : MonoBehaviour
{
    public string[,] quotesByYear = {{2020,"Statues are about saying 'This was a great man who did great things.' That is not true, he [Colston] was a slave trader and a murderer." ,"Professor David Olusoga", "BBC Article"},
                        {2020, "is part of a history that shouldn't be glorified", "Keziah Wenham-Kenyon", "BBC Article"},
                        {2020, "I never thought I would witness such an empowering moment that I can tell my children about,", "Salma Omar", "BBC Article"},
                        {2021, "...statues are a symbol of how seriously our cities in Britain are actually taking these issues.", "Dr Shawn Sobers", "BBC Article"},
                        {2021, "The future of the statue must be decided by the people of Bristol and so I urge everyone to take the opportunity to share their views.", "Marvin Rees", "BBC Article"},
                        };

    public GameObject Clipping;
    public GameObject[] ClippingInstances;
    private int clippingCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateQuote(float value)
    {   
        switch(value)
        {
            case "2020":
            clippingCounter = 0;
                for (int i = 0; i < quotesByYear.GetLength(0); i++){
                    if (quotesByYear[0][i] == "2020"){
                        clippingCounter++;
                        private string stringQuote = quotesByYear[1][i];
                        private string stringPerson = quotesByYear[2][i];
                        private string stringSource = quotesByYear[3][i];

                        Vector3 position = new Vector3(Random.Range(-5.0f, 0.0f), Random.Range(-5.0f, 0.0f), Random.Range(-5.0f, 0.0f));//position of clipping
                        ClippingInstances.Add(Instantiate(Clipping, position, Quaternion.identity));//add clipping to empty object to contain all clippings

                        GameObject Quote = Clipping.transform.GetChild(0).gameObject;//gather each child
                        GameObject Person = Clipping.transform.GetChild(1).gameObject;
                        GameObject Source = Clipping.transform.GetChild(2).gameObject;

                        Debug.Log("quote from 2020");
                    }
                }
                
            break;
        }
       
    }
}
