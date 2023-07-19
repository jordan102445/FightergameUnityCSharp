using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class odzemanjeZdravje : MonoBehaviour
{
    Text zdravjeMinus;


    void Start()
    {
        zdravjeMinus = GetComponent<Text>();
    }


    void Update()
    {

        if (zdravjeMinus.text != zdravjeScripta.zdravje.ToString())
        {
            zdravjeMinus.text = zdravjeScripta.zdravje.ToString();
        }
    }
}
