using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Light_Controller : MonoBehaviour
{
    [SerializeField]
    private InputField inputField;
    [SerializeField]
    private Text textField;
    [SerializeField]
    private Light Point_Light;
    [SerializeField]
    private int voltage;

    void Start()
    {
        click_Get_Voltage_Button();
    }

    public void click_Get_Voltage_Button()
    {
        textField.text = inputField.text;
        int temp;
        if (int.TryParse(inputField.text, out temp))
        {
           voltage = temp;
            Point_Light.intensity = voltage;
        }
    }
}
