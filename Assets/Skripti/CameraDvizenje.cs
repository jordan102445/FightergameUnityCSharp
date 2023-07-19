using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraDvizenje : MonoBehaviour
{
   

    public float BrzinaNaKamera = 3f;
    public Transform igrac;


    

    void Update()
    {
        Vector3 pozicija = new Vector3(igrac.position.x, igrac.position.y, -10f); // pozicija na igracot za x i y  z nema ako bese 0 nemase da se vidi igracot

        transform.position = Vector3.Slerp(transform.position, pozicija,BrzinaNaKamera*Time.deltaTime);


        
    }

   
}
