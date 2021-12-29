using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takip : MonoBehaviour
{
    public Transform karakter;
    void Start()
    {
        
    }

    
    void Update()
    {
       if(karakter.position.y>transform.position.y)
       {
           transform.position=new Vector3(transform.position.x,karakter.position.y,transform.position.z);
       } 
    }
}
