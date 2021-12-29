using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seviye : MonoBehaviour
{

    public GameObject platformlar;
    public float maxX,minX;
    public int platformsayisi;
    public float maxY,minY;

   

    void Start()
    {
         Vector2 pozisyon=new Vector2();
        for(int i=0;i<platformsayisi;i++)
        {
            pozisyon.y=Random.Range(minY,maxY);
            pozisyon.x=Random.Range(minX,maxX);
            Instantiate(platformlar,pozisyon,Quaternion.identity);
        }
        
    }

    void Update()
    {
        
    }
}
