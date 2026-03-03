using UnityEngine;

public class getYear : MonoBehaviour

    public Text text;
    public void UpdateText(float f){
        text.text = f.ToString();
    }

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text.Component = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
