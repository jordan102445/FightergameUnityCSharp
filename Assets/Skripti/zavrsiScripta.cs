using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class zavrsiScripta : MonoBehaviour
{
    public Text poeniShow;
    public void Setup(int poeni)
    {
        gameObject.SetActive(true);
        poeniShow.text = poeni.ToString() + "POENI";

    }
}


