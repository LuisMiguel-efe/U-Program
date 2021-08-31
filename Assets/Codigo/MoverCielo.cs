using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverCielo : MonoBehaviour
{
    

    public GameObject menuStart; //Menu Intro
    public GameObject menuFinal;  //Menu Game Over
   
    public bool boolStart = false;
    public bool boolGameOver = false;
    

    public GameObject popoFalso;
    public GameObject bono;
    public GameObject popo1;
    public List<GameObject> obsFalsos;
    public List<GameObject> obstaculos;
    public List<GameObject> bonus;

    public float speed = 3;

    


    public Renderer cielo;
    void Start()
    {

        
        //   //   //    //

        //CREAR OBSTACULOS POPO
        int randomx = Random.Range(-23, 23);
        obstaculos.Add(Instantiate(popo1, new Vector2(randomx, 35), Quaternion.identity));
        //   //   //    //

        //CREAR OBSTACULO FALSO
        obsFalsos.Add(Instantiate(popoFalso, new Vector2(8, 35), Quaternion.identity));
        //   //   //    //

    }

    // Update is called once per frame
    void Update()
    {  
       
        // EMPEZAR JUEGO AL PULSAR X
        if (boolStart == false)
        {
            if (Input.GetKeyDown(KeyCode.X)) 
            {
                
                boolStart = true;
               
                
            }
        }

        // SI EL JUGADOR PIERDE, MOSTRAR MENU GAME OVER Y ANIDADO, SI PULSA X, SE REINICIA EL JUEGO
        if (boolStart == true && boolGameOver == true)
        {
            menuFinal.SetActive(true);
            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            } 
        }
        
        // SI PULSA X EL MENU GAME OVER SE DEBE ESCONDER
        if (boolStart==true && boolGameOver == false)
        {
            menuStart.SetActive(false);

           //

            //MOVER OBSTACULOS POPO
            for (int i = 0; i < obstaculos.Count; i=i+10)
            {
                if (obstaculos[i].transform.position.y <= -3)
                {
                    int randomObstaX = Random.Range(-22, 22);
                    int randomObstacY = Random.Range(35, 50);
                    obstaculos[i].transform.position = new Vector3(randomObstaX, randomObstacY, 0);
                }
                obstaculos[i].transform.position = obstaculos[i].transform.position + new Vector3(0,-1) * Time.deltaTime * speed;
            }
            // Obstaculo Salvador o Falso
            for (int i = 0; i < 1; i++)
            {
                if (obsFalsos[i].transform.position.y <= 3)
                {
                    obsFalsos[i].transform.position = new Vector3(8,33 , 0);
                }
                obsFalsos[i].transform.position = obsFalsos[i].transform.position + new Vector3(0, -1) * Time.deltaTime * speed;
            }
            //   //   //   //   //

            
            //   //   //   //





        }


    }
   









}
