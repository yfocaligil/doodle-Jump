using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class karakterx : MonoBehaviour
{
    public float karakterhiz;
    private float hareket;
    public Rigidbody2D doodle;
    public TextMeshProUGUI skoryazisi;
    int skor;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D temas) 
        {
      if(temas.gameObject.tag=="olum")
       {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

       }
       if(temas.gameObject.tag=="platform")
       {
          skor++;
       }

    }
    void Update()
    {
       hareket=Input.GetAxis("Horizontal");
       transform.Translate(karakterhiz*hareket*Time.deltaTime,0f,0f);

       skoryazisi.text="SKOR:"+" "+skor;

       //if(Input.GetKey(KeyCode.LeftArrow))
       //{
          // transform.Translate(-karakterhiz*Time.deltaTime,0f,0f);
       //}
      // if(Input.GetKey(KeyCode.RightArrow))
      // {
          // transform.Translate(karakterhiz*Time.deltaTime,0f,0f);
     //  }

        }
        
    }

