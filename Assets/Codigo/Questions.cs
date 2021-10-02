using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    // MENUS PREGUNTAS
    public GameObject question; 
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;
    public GameObject question5;
    // SONIDOS BOTONES
    public AudioClip correctSound;
    public AudioClip errorSound;
   

    private void OnTriggerEnter2D(Collider2D collis)
    {
        
        if (collis.CompareTag("Player") && question != null)
        {
            //Musica

            Camera.main.GetComponent<AudioSource>().volume = 0.1f;

            // Pausar, mostrar pregunta
            Time.timeScale = 0;
            question.SetActive(true);
            
            // Esconder Bono
            GetComponent<SpriteRenderer>().enabled = false;
            // Destruir Bono
            Destroy(gameObject, 0.2f);
        } else
        if (collis.CompareTag("Player") && question2 != null )
        {
            //Musica

            Camera.main.GetComponent<AudioSource>().volume = 0.1f;

            // Pausar, mostrar pregunta
            Time.timeScale = 0;
            question2.SetActive(true);
            
            // Esconder Bono
            GetComponent<SpriteRenderer>().enabled = false;
            // Destruir Bono
            Destroy(gameObject, 0.2f);
        } else
            if (collis.CompareTag("Player") && question3 != null )
        {
            //Musica
            Camera.main.GetComponent<AudioSource>().volume = 0.1f;
            // Pausar, mostrar pregunta
            Time.timeScale = 0;
            question3.SetActive(true);
            
            // Esconder Bono
            GetComponent<SpriteRenderer>().enabled = false;
            // Destruir Bono
            Destroy(gameObject, 0.2f);

        }
        else
            if (collis.CompareTag("Player") && question4 != null)
        {
            //Musica
            Camera.main.GetComponent<AudioSource>().volume = 0.1f;
            // Pausar, mostrar pregunta
            Time.timeScale = 0;
            question4.SetActive(true);

            // Esconder Bono
            GetComponent<SpriteRenderer>().enabled = false;
            // Destruir Bono
            Destroy(gameObject, 0.2f);

        }
        else
            if (collis.CompareTag("Player") && question5 != null)
        {
            //Musica
            Camera.main.GetComponent<AudioSource>().volume = 0.1f;
            // Pausar, mostrar pregunta
            Time.timeScale = 0;
            question5.SetActive(true);

            // Esconder Bono
            GetComponent<SpriteRenderer>().enabled = false;
            // Destruir Bono
            Destroy(gameObject, 0.2f);

        }







    }

    public void FadeQuestion()
    {
        Time.timeScale = 1;
    
        question.SetActive(false);
        question2.SetActive(false);
        question3.SetActive(false);
        question4.SetActive(false);
        question5.SetActive(false);
        Camera.main.GetComponent<AudioSource>().volume = 0.3f;
    }
    public void CorrectSound()
    {
        Camera.main.GetComponent<AudioSource>().PlayOneShot(correctSound);
        
    }
    public void ErrorSound()
    {
        Camera.main.GetComponent<AudioSource>().PlayOneShot(errorSound);
        
    }
    


}
