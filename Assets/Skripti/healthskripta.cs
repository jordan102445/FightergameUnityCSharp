using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthskripta : MonoBehaviour
{
    public Slider slider ;
    public Gradient grad; // za 100 zeleno 50 zolto 20-10-0 crveno
    public Image popunuvanjeNaZdravje;

    public void MaxZdravje(int zdravje)
    {
        slider.maxValue = zdravje;
        slider.value = zdravje;
        grad.Evaluate(1f); // 0-100 1f e 100
        popunuvanjeNaZdravje.color = grad.Evaluate(1f); // maxZdravje e 100 ili 1f

    }

    public void Zdravje (int zdravje)
    {

        slider .value = zdravje;
        popunuvanjeNaZdravje.color = grad.Evaluate(slider.normalizedValue); 
    }


}
