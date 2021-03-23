using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Handle : MonoBehaviour
{
    [SerializeField] GameObject board;
    public TMP_Text valueText;

    private void Start()
    {
    }
    public virtual void ValueChange(Slider slider)
    {
        valueText.text = slider.value.ToString();
    }

    public void OnPressed()
    {
        board.SetActive(true);
    }

    public void OnUpPrssed()
    {
        board.SetActive(false);
    }
}
