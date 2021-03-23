using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EMHandle : Handle
{
    [SerializeField] Slider amSlider;
    void Start()
    {
    }

    public override void ValueChange(Slider slider)
    {
        base.ValueChange(slider);
        if (slider.value < amSlider.value + 2)
        {
            slider.SetValueWithoutNotify(amSlider.value + 2);
            valueText.text = (amSlider.value + 2).ToString();
        }
    }
}
