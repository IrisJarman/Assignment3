using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

	public static int PinCount;

	public Text text;

	void Update()
	{
		text.text = "Score: " + PinCount.ToString();
	}

}