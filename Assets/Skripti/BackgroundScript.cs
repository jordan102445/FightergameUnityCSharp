using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

    [Range(-1f,1f)] // za dvizenjeto na kamerata
    public float brzinaNaDvizenje = 0.5f;
    private float offset;
    private Material m;
    void Start()
    {

        m = GetComponent<Renderer>().material; // zemame go materjalo
    }

   
    void Update()
    
    {

        offset += (Time.deltaTime * brzinaNaDvizenje) / 10f;
        m.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
