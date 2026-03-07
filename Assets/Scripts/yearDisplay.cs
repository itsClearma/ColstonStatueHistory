using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;

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
    [SerializeField] private bool showDecimalPoints;

    private void Reset()
    {
        slider = GetComponent<Slider>();
        textField = GetComponentInChildren<TMP_Text>();
    }

    public void HandleSliderValueChanged(float value)
    {
        if (showDecimalPoints)
        {
            textField.SetText(value.ToString(format: "F2"));
        }
        else
        {
            textField.SetText(value.ToString(format: "F0"));
        }
    }
}