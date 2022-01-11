using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetData : MonoBehaviour
{
    public Slider slider;
    public Data data;

    private void Start()
    {
        slider.value = data.speed / 1000;

    }
    // Update is called once per frame
    void Update()
    {
        data.speed = slider.value * 1000;
    }
}
