using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransicionLevel : MonoBehaviour
{
    public GameObject director;
    public AudioClip soundTransition;
    public string sceneName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(LoadLevel());
        }
    }
    
    IEnumerator LoadLevel()
    {
        director.SetActive(true);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(soundTransition);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(sceneName);
    }
   
    
}
