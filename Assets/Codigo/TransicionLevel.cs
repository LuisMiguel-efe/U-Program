using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransicionLevel : MonoBehaviour
{
    public GameObject director;
    public AudioClip soundTransition;
    public bool transReady = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           
           
            director.SetActive(true);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundTransition);
            transReady = true;
            
        }
        ToLevl();

    }
    public void ToLevl()
    {
        if (transReady)
        {
            SceneManager.LoadScene("Level2");

        }
    }   
}
