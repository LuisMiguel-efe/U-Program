using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;
    
    
    
    public void PauseMenu()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void Reanudar()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    
    public void GoToLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void GoToHome()
    {
        SceneManager.LoadScene("SampleScene");
    }
    







}
