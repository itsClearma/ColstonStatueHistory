using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class yearDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text textField;
    [SerializeField] public int yearNumber;
    [SerializeField] public TMP_Text yearEventField;

    private void Reset()
    {
        slider = GetComponent<Slider>();
        textField = GetComponentInChildren<TMP_Text>();
        yearEventField = GetComponentInChildren<TMP_Text>();
    }

    public void HandleSliderValueChanged(float value)
    {
        yearNumber = Convert.ToInt32(value);
        textField.SetText(value.ToString(format: "F0"));

        //event titles
        switch (value)
        {
            case (1895):
                yearEventField.SetText("The statue of Edward Colston is installed");
            break;
            case (2020):
                yearEventField.SetText("BLM protestors pull down and deface the statue.");
            break;
            default:
                yearEventField.SetText("");
            break;
        }
    }
}