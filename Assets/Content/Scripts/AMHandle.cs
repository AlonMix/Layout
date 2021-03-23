using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AMHandle : Handle
{
    [SerializeField] Slider emSlider;
    void Start()
    {
    }
    public override void ValueChange(Slider slider)
    {
        base.ValueChange(slider);
        if (slider.value > emSlider.value - 2)
        {
            slider.SetValueWithoutNotify(emSlider.value - 2);
            valueText.text = (emSlider.value - 2).ToString();
        }
    }
}
