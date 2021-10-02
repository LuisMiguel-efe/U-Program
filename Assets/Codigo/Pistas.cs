using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistas : MonoBehaviour
{
    public GameObject pista1;
    public GameObject pista2;
    public GameObject pista3;
    public GameObject pista4;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && pista1 != null)
        {
            Time.timeScale = 0;
            pista1.SetActive(true);

            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.2f);
            
        } 
        else
        if (collision.CompareTag("Player") && pista2 != null)
        {
            Time.timeScale = 0;
            pista2.SetActive(true);

            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.2f);
            
        }
        else
            if (collision.CompareTag("Player") && pista3 != null)
        {
            Time.timeScale = 0;
            pista3.SetActive(true);

            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.2f);

        }
        else
            if (collision.CompareTag("Player") && pista4 != null)
        {
            Time.timeScale = 0;
            pista4.SetActive(true);

            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.2f);

        }





    }

    public void fadePistas()
    {
        Time.timeScale = 1;
        pista1.SetActive(false);
        pista2.SetActive(false);
        pista3.SetActive(false);
        pista4.SetActive(false);
    }
    







}
