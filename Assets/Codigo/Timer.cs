using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text tiempo;

    private float timeRestante;
    public static bool timeActive;

    
    private void Awake()
    {
        timeRestante = (min * 60) + seg;
        tiempo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeActive)
        {

            tiempo.gameObject.SetActive(true);
            
            timeRestante -= Time.deltaTime;
            if (timeRestante < 1)
            {
                
                timeActive = false;
                Player.muerteExterior = true;
                //Matar Jugador
            }

            int timeInMin = Mathf.FloorToInt(timeRestante / 60);
            int timeInSeg = Mathf.FloorToInt(timeRestante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", timeInMin, timeInSeg);

        }


    }
}
