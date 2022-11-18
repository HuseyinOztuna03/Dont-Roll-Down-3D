using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform current_pos;
    Vector3 remainder;
    void Start()
    {
        remainder = transform.position - current_pos.position;
    }

    void Update()
    {
        if(Ball.fall == false)
        {
            transform.position = current_pos.position + remainder;
        }
    }
}
