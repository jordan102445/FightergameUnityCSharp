using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zdravjeScripta : MonoBehaviour
{
    public static int zdravje = 100;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Podot")
        {
            
            zdravje = zdravje - 5;
            
            Debug.Log("Via imate  " + zdravjeScripta.zdravje + " Zdravje.");
            
        }
    }
}
