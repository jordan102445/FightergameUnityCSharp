using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DvizenjeNaIgracot : MonoBehaviour
{

    private Rigidbody2D rigidbody2;

    private float brzinaNaigracot;
    private float skokanjeNaigracot;
    private bool daliSkoknalIgracot;
    private float odiHorizontalno;
    //private float odiVerticalno;
    public Animator animator;
   
    


    
    void Start()
    {
        rigidbody2 = gameObject.GetComponent<Rigidbody2D>();
        brzinaNaigracot = 60f;
        skokanjeNaigracot = 320f;
        daliSkoknalIgracot = false;
        
    }

    void Update()
    {
        odiHorizontalno = Input.GetAxisRaw("Horizontal");

        
        animator.SetFloat("brzoOdi", Mathf.Abs(odiHorizontalno));

        if(Input.GetKeyUp(KeyCode.Space))
        {
            daliSkoknalIgracot=true;
        }
        //odiVerticalno = Input.GetAxisRaw("Vertical");

        
    }

    private void FixedUpdate()
    {
        
        if(odiHorizontalno > 0.1f || odiHorizontalno < 0.1f)  // 0.1f za Desno -0,1f za Levo
            {

            rigidbody2.AddForce(new Vector2(odiHorizontalno * brzinaNaigracot, 0f), ForceMode2D.Impulse);



        }

        if (daliSkoknalIgracot)
        {

            daliSkoknalIgracot = false;

            rigidbody2.AddForce (new Vector2(0f,skokanjeNaigracot), ForceMode2D.Impulse);
        }

        //if(!daliSkoknalIgracot && odiVerticalno > 0.1f)
        //{
            //rigidbody2.AddForce(new Vector2(0f,odiVerticalno * skokanjeNaigracot),ForceMode2D.Impulse);
        //}
        

    }


     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Podot")
        {
            daliSkoknalIgracot = false;
        }
    }

      void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Podot")
        {

            daliSkoknalIgracot = true;
        }
    }
}
