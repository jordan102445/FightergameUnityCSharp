using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sobiranje : MonoBehaviour
{
   
    public static int paricki = 0;

    void Awake()
    {
        
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        
        if (collider2D.CompareTag("Podot"))
        {
            
            paricki++;
            
            Debug.Log("Via imate  " + Sobiranje.paricki + " Paricki.");
            
            Destroy(gameObject);
        }
    }
}

