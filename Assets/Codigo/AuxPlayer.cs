using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuxPlayer : MonoBehaviour
{

    public GameObject question1;

    private void OnTriggerEnter2D(Collider2D collis)
    {

        if (collis.CompareTag("Player") && question1 != null)
        {

            Time.timeScale = 0;
            question1.SetActive(true);
            GetComponent<SpriteRenderer>().enabled = false;

            Destroy(gameObject, 0.2f);
        }




    }
    public void FadeQuestion()
    {
        Time.timeScale = 1;
        question1.SetActive(false);
    }

}
