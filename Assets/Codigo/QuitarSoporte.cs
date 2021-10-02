using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarSoporte : MonoBehaviour
{

    /// SEGUNDO NIVEL
    public AudioClip soundDestroy;
    public GameObject soporte;
    public GameObject soporte2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundDestroy);
            soporte.SetActive(false);
            soporte2.SetActive(false);
            GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.2f);
        }
    }


}
