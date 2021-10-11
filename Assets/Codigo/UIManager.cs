using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu; // Panel de Pausa
    
    // FUNCIONES PARA LOS BOTONES
    
   
   ///  Button Pause  
    public void PauseMenu()
    {
        Camera.main.GetComponent<AudioSource>().Pause();
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        
    }
   
   ///  Button Continue
    
    public void Reanudar()
    {
        Camera.main.GetComponent<AudioSource>().UnPause();
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
   /// Button Icon First Level 
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1;
    }
   /// Button Back 
    public void GoToHome()
    {
        SceneManager.LoadScene("SampleScene");
    }
   
   /// Button Icon First Level 
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
