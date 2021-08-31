using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject Juan;
    private Animator animato;
    
    // Start is called before the first frame update
    void Start()
    {       
        animato = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            animato.SetBool("estaAbierta", true);
        }
    }
}
