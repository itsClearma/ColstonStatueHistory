using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
//using SimpleJSON;
using TMPro;

public class quotePlacer : MonoBehaviour
{
    public string[,] quotesByYear = {
        {"1911","...the President [J.H. Howell], in proposing [a toast for] “The Pious Memory of Edward Colston,” referred to the many benefactions of the great Bristol philanthropist, who lived 200 years ago, specially mentioning the educational side of his benevolence."," ","The British Medial Society"},
        {"1922", "[The University Colston Research Society,] Originally founded in 1899 and named in honour of the famous philanthropist, Edward Colston…", "Colston University Research Society", "Nature"},
        {"2017", "For how much longer are school children expected to commemorate Colston in the city’s cathedral whilst conveniently disregarding the memory of enslaved Africans whose lives were brutalised and cheapened by the trade in human cargo?", " ", "Bristol Radical History Group"},
        {"2018","Having statues of people who oppressed us is not a good thing to be saying to black people in this city." ,"Thangam Debbonaire", "BBC News"},
        {"2020","Statues are about saying 'This was a great man who did great things.' That is not true, he [Colston] was a slave trader and a murderer." ,"Professor David Olusoga", "BBC News"},
        {"2020", "it's part of a history that shouldn't be glorified", "Keziah Wenham-Kenyon", "BBC News"},
        {"2020", "I never thought I would witness such an empowering moment that I can tell my children about,", "Salma Omar", "BBC News"},
        {"2021", "...statues are a symbol of how seriously our cities in Britain are actually taking these issues.", "Dr Shawn Sobers", "BBC News"},
        {"2021", "The future of the statue must be decided by the people of Bristol and so I urge everyone to take the opportunity to share their views.", "Marvin Rees", "BBC News"},
        {"2023", "Edward Colston’s career as a merchant was far darker than many children in his home city of Bristol were taught.","JR Sidhu", "The Clueless Conscience"},
        {"2025", "This has led, by default, to a defence of his position as the ‘great Bristol philanthropist’ whilst ignoring the immense human suffering he and others of his class propagated for profit.", "Roger Ball", "Bristol Radical History Group"},

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

                Vector3 position = new Vector3(Random.Range(-1.0f, 2.5f), Random.Range(0.4f, 2.0f), Random.Range(0.5f, 2.5f));//position of clipping

                Instantiate(Clipping, position, Quaternion.identity);//place clipping prefab

            }
        }

        // int check = false;
        // while (check = false){

        //     foreach (GameObject Clipping in GameObject.FindGameObjectsWithTag("Clipping")) {

        //         foreach (GameObject Clipping in GameObject.FindGameObjectsWithTag("Clipping")) {//collide with each other
        //             Debug.log(" ");
        //             if (coins[i].intersects(coins[j]) == true) {
        //             check = true;
        //             }
        //         }
        //         if (dist(coins[i].x, coins[i].y, width / 2, width / 2) < 140) {//collide with centre
        //             check = true;
        //         }
        //         }

        //         if (check == true) {
        //         check = false;
        //         } else {
        //         Debug.log("no collision");
        //         }
        //     } //repawn coins with no collision with eye or each other
        // }

    }
}//clipping x -1 +1
// z 1 2
