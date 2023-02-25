using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = KeepData.RotatorSpeed;

    private void Update()
    {
        speed = KeepData.RotatorSpeed;
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
