using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrojacZaParicki : MonoBehaviour
{
    Text brojacNaParicki;

    
    void Start()
    {
        brojacNaParicki = GetComponent<Text>();
    }

    
    void Update()
    {
        
        if (brojacNaParicki.text != Sobiranje.paricki.ToString())
        {
            brojacNaParicki.text = Sobiranje.paricki.ToString();
        }
    }
}
