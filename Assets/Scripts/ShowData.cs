using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShowData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PlayerScoreText;


    private void Awake()
    {
        PanelNameText.text = "Name: " + KeepData.PlayerName;
        PlayerScoreText.text = "Score: " + Score.PinCount;

    }
}
