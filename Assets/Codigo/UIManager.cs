using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu; //Menu de Pausa
    
    // FUNCIONES PARA LOS BOTONES
    
    public void PauseMenu()
    {
        Camera.main.GetComponent<AudioSource>().Pause();
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void Reanudar()
    {
        Camera.main.GetComponent<AudioSource>().UnPause();
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
    
    public void GoToHome()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GoToLevel2()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }

    public void ExitGame()
    {
        Application.Quit();
    }




}
