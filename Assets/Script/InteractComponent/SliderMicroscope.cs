using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderMicroscope : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI valueText;
    [SerializeField] private GameObject blur;

    [SerializeField] private GameObject cross;
    [SerializeField] private GameObject slab;
    [SerializeField] private GameObject powder;

    float BlurValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            valueText.text = v.ToString("0.00");
            blur.GetComponent<Image>().material.SetFloat("_Size", v*4-BlurValue*4);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void crossActivated()
    {
        BlurValue = 0.5f;
        blur.GetComponent<Image>().material.SetFloat("_Size", slider.value * 4 - BlurValue * 4);
    }
    public void slabActivated()
    {
        BlurValue = 1f;
        blur.GetComponent<Image>().material.SetFloat("_Size", slider.value * 4 - BlurValue * 4);
    }
    public void powderActivated()
    {
        BlurValue = 0.5f;
        blur.GetComponent<Image>().material.SetFloat("_Size", slider.value * 4 - BlurValue * 4);
    }
}
