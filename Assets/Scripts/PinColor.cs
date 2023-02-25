using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinColor : MonoBehaviour
{
    SpriteRenderer sprite;

    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        sprite.color = KeepData.PinColor;
    }
}
