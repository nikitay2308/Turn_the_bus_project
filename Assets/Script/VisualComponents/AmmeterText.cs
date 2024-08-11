using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AmmeterText : MonoBehaviour
{
    [SerializeField] TextMeshPro AmmeterValue;

    public void UpdateAmmeterValue(double ammeterValue)
    {
        if(ammeterValue >= 100 || ammeterValue <= -100) { AmmeterValue.text = string.Format("{0:0.##}", ammeterValue / 1000) + "A"; }
        else { AmmeterValue.text = string.Format("{0:0.##}", ammeterValue) + "mA"; }

        // AmmeterValue.text = string.Format("{0:0.##}", ammeterValue/1000) + " mA";
        // AmmeterValue.text = string.Format("{0:0.##}", ammeterValue) + " Ω";
    }

    public void InitAmmeterValue()
    {
        AmmeterValue = GetComponent<TextMeshPro>();
    }
}
