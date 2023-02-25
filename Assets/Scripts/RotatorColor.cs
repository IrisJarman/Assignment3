using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorColor : MonoBehaviour
{
    SpriteRenderer sprite; 

    void Start()
    {

        sprite = GetComponent<SpriteRenderer>();
        sprite.color = KeepData.RotatorColor;
    }
}
