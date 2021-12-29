using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziplama : MonoBehaviour
{
    


    public float ziplamagucu;
    public Rigidbody2D fizik;
    private Vector2 karakterhizi;
    void Start()
    {
        
    }

private void OnCollisionEnter2D(Collision2D temas) 
{ if(temas.relativeVelocity.y<=0)
    fizik=temas.collider.GetComponent<Rigidbody2D>();
    if(fizik!=null)
    {
        karakterhizi=fizik.velocity;
        karakterhizi.y=ziplamagucu;
        fizik.velocity=karakterhizi;
    }
     
    
}
    
    private void OnTriggerStay2D(Collider2D temas1) 
    {
        //if(temas1.gameObject.tag=="kontrolcubuk")
   // {
        //transform.position=new Vector2(Random.Range(-8.80f,8.80f),transform.position.y+19f);
    //}
    }
    void Update()
    {
        
    }
}
