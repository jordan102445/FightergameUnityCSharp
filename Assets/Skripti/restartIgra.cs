using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartIgra : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void RestartNaIgra ()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Rabote");

    }
}
