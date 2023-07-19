using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthbarSlider : MonoBehaviour
{
    public ZdravjeNaIgracotprobaskripta zdravjeIgracc;
    public Image img;
    public Slider slide;

    private void Awake()
    {
       
        slide = GetComponent<Slider>();
    }

    private void Start()
    {
        
        slide.minValue = 0;
        slide.maxValue = 1;

    }

    
    void Update()
    {
        float vrednostSlider = zdravjeIgracc.zdravje / zdravjeIgracc.maxZdravje;
        slide.value = vrednostSlider;
        
    }
}
