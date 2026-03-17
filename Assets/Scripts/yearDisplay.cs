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

    private void Reset()
    {
        slider = GetComponent<Slider>();
        textField = GetComponentInChildren<TMP_Text>();
    }

    public void HandleSliderValueChanged(float value)
    {
        yearNumber = Convert.ToInt32(value);
        //Debug.Log("yearNumber: " + yearNumber);
        textField.SetText(value.ToString(format: "F0"));
    }
}