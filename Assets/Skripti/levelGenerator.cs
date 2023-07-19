using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGenerator : MonoBehaviour
{
    [SerializeField] private Transform stageEden;
   


    private void Awake()
    {
        

        Pojavuvanje(new Vector3(-730, -17)); // prvata pozicja na prvio stage

        for (int i = 0; i < 2; i++ ) // se formira plus dva klona isto taka i stages
        {
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i+80, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i+160, 0));
            

        }

        for (int i = 0; i < 3; i++) // plus 3 klona i se odelucuvat isto taka i stages
        {
            
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 240, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 320, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 400, 0));



        }

        for (int i = 0; i < 4; i++) // plus 4 klona i se odelucuvat isto taka i stages
        {

            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 480, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 560, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 620, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 700, 0));



        }
        for (int i = 0; i < 3; i++) // plus 3 klona i se odelucuvat isto taka i stages
        {

            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 780, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 860, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 940, 0));
           



        }


        for(int i = 0; i < 2; i++) // plus 2 klona i se odelucuvat isto taka i stages
        {

            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 1020, 0));
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 1100, 0));
           



        }
        for (int i = 0; i < 1; i++)
        {
            Pojavuvanje(new Vector3(-730, -17) + new Vector3(i + 1180, 0));
        }

        

      



    }
    

    private void Pojavuvanje(Vector3 pojavuvanjePozicija)
    {

        Instantiate(stageEden,pojavuvanjePozicija,Quaternion.identity);
    }



}