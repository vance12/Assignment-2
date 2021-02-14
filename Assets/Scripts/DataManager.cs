using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Dropdown color;

    public Slider speed;

    public Toggle Oversized;

    public void Update()
    {
        Data.Instance.speed = speed.value;
        Data.Instance.color = color.value;
        Data.Instance.oversized = Oversized.isOn;

    }
    //GameObject player = GameObject.FindWithTag("Player");
}

