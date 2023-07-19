using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StetaOdEnemy : MonoBehaviour
{
    public ZdravjeNaIgracotprobaskripta zdravjeIgrac;
    public int dmg = 5;

   

    void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Podot")
        {
            zdravjeIgrac.StetaNaIgrac(dmg);
        }
    }
}
