using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Material cubeMat;
    public Slider slider;

    private void Update()
    {
        cubeMat.color = new Color(slider.value, slider.value, slider.value);
    }
}
