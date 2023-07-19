using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZdravjeNaIgracotprobaskripta : MonoBehaviour
{
    public int zdravje = 100;
    public int maxZdravje = 100;
    ZdravjeNaIgracotprobaskripta zdravjeIgrac;


    

    void Start()
    {
        zdravje = maxZdravje; // zdravje da pocne so 100

        
    }


    public void StetaNaIgrac(int steta)
    {


        zdravje -= steta;

        if (zdravje <= 0)
        {

            Destroy(gameObject);
        }


    }



}





