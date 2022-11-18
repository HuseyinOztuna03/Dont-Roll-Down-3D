using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColor : MonoBehaviour
{
    [SerializeField] private Material ground_material;
    [SerializeField] private Color[] colors;
    private int color_index = 0;
    [SerializeField] private float lerp_value;
    [SerializeField] private float time;
    private float current_time;
     
    void Update()
    {
        SetColorChangeTime();
        SetGroundMaterial();
    }

    private void SetColorChangeTime()
    {
        if(current_time <= 0)
        {
            CheckColorIndexValue();
            current_time = time;
        }
        else
        {
            current_time -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        color_index++;

        if(color_index >= colors.Length)
        {
            color_index = 0;
        }
    }

    private void SetGroundMaterial()
    {
        ground_material.color = Color.Lerp(ground_material.color, colors[color_index], lerp_value * Time.deltaTime);
    }

    /*private void OnDestroy()
    {
        ground_material.color = colors[1];
    }*/
}   
