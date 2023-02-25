using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName;
    public static float PinSpeed;
    public static float RotatorSpeed;
    public static Color RotatorColor;
    public static Color PinColor;

    

    public InputField PlayerNameInput;
    public Slider PinspeedSlider;
    public Slider RotatorSpeedSlider;
    public Dropdown PinColorDrop;
    public Dropdown RotatorColorDrop;

    public Text RotatorSpeedText;
    public Text PinSpeedText;


    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateName() 
    {
        PlayerName = PlayerNameInput.text;
        Debug.Log(PlayerName);
    }

    public void SetPinSpeed() 
    {
        PinSpeed = PinspeedSlider.value;
        PinSpeedText.text = PinSpeed.ToString();
    }

    public void ShowPinSpeed() 
    {
        PinSpeedText.text = PinSpeed.ToString();
        PinspeedSlider.value = PinSpeed; 

    }

    public void SetRotatorSpeed()
    {
        RotatorSpeed = RotatorSpeedSlider.value;
        RotatorSpeedText.text = RotatorSpeed.ToString();
    }

    public void ShowRotatorSpeed()
    {
        RotatorSpeedText.text = RotatorSpeed.ToString();
        RotatorSpeedSlider.value = RotatorSpeed;
    }
    public void SetRotatorColor()
    {
        switch (RotatorColorDrop.value) {
            case 1:
                RotatorColor = Color.blue;
                break;
            case 2:
                RotatorColor = Color.red;
                break;
            case 3:
                RotatorColor = Color.black;
                break;
            default:
                break;

        }
    }
    

    public void SetPinColor()
    {
        switch (PinColorDrop.value)
        {
            case 1:
                PinColor = Color.blue;
                break;
            case 2:
                PinColor = Color.red;
                break;
            case 3:
                PinColor = Color.black;
                break;
            default:
                break;

        }
    }

}
