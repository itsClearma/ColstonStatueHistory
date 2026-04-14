using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
//using SimpleJSON;
using TMPro;

public class quotePlacer : MonoBehaviour
{
    public string[,] quotesByYear = {
        {"2020","Statues are about saying 'This was a great man who did great things.' That is not true, he [Colston] was a slave trader and a murderer." ,"Professor David Olusoga", "BBC Article"},
        {"2020", "it's part of a history that shouldn't be glorified", "Keziah Wenham-Kenyon", "BBC Article"},
        {"2020", "I never thought I would witness such an empowering moment that I can tell my children about,", "Salma Omar", "BBC Article"},
        {"2021", "...statues are a symbol of how seriously our cities in Britain are actually taking these issues.", "Dr Shawn Sobers", "BBC Article"},
        {"2021", "The future of the statue must be decided by the people of Bristol and so I urge everyone to take the opportunity to share their views.", "Marvin Rees", "BBC Article"}
    };

    [SerializeField] public GameObject Clipping;
    private string yearText;

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
        string yearText = value.ToString();
        foreach (GameObject Clipping in GameObject.FindGameObjectsWithTag("Clipping"))
        {
            Destroy(Clipping);
        }
        for (int i = 0; i < quotesByYear.GetLength(0); i++)//go thru each year
        {
            if (quotesByYear[i,0] == yearText)
            {
                string stringQuote = quotesByYear[i,1];//data from 2d array
                string stringPerson = quotesByYear[i,2];
                string stringSource = quotesByYear[i,3];
                
                TextMeshPro quoteTextComponent = Clipping.transform.GetChild(0).GetComponent<TextMeshPro>();//gather clipping texts
                TextMeshPro personTextComponent = Clipping.transform.GetChild(1).GetComponent<TextMeshPro>();
                TextMeshPro sourceTextComponent = Clipping.transform.GetChild(2).GetComponent<TextMeshPro>();

                quoteTextComponent.text = stringQuote;//assign data
                personTextComponent.text = stringPerson;
                sourceTextComponent.text = stringSource;

                Vector3 position = new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(0.5f, 2.0f), Random.Range(0.0f, 1.5f));//position of clipping
                Instantiate(Clipping, position, Quaternion.identity);//place clipping prefab
            }
        }     
    }
}
