using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverCielo : MonoBehaviour
{
   

    public GameObject menuStart;          // Menu Introducccion
    public GameObject menuFinal;          // Menu Game Over
   
    public bool boolStart = false;        // Bool Menu de Start
    public bool boolGameOver = false;     // Bool Menu Game Over  
    
    
    public GameObject popoFalso;          // Obstaculo "Salvador"
    public GameObject popo1;              // Obstaculo  
    public GameObject fuego1;
    public GameObject roca1;

    public List<GameObject> obsFalsos;
    public List<GameObject> obstaculos;
    public List<GameObject> obsFuego;
    public List<GameObject> obsRoca;

    public float speed;                   // Velocidad Caida de Obstaculos

    public Renderer cielo;                // Fondo

    
    void Start()
    {          
        //CREAR OBSTACULOS POPO
        int randomx = Random.Range(-23, 23);
        obstaculos.Add(Instantiate(popo1, new Vector2(randomx, 35), Quaternion.identity));
        //   //   //    //

        //CREAR OBSTACULO FALSO
        obsFalsos.Add(Instantiate(popoFalso, new Vector2(8, 35), Quaternion.identity));
        //   //   //    //

        //CREAR OBSTACULO FUEGO
        int randX = Random.Range(-23, -1);
        obsFuego.Add(Instantiate(fuego1, new Vector2(randX, 45), Quaternion.identity));
        //   //   //    //

        //CREAR OBSTACULO ROCA
        int randiX = Random.Range(1, 23);
        obsRoca.Add(Instantiate(roca1, new Vector2(randiX, 45), Quaternion.identity));
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
                Timer.timeActive = true;
                boolStart = true;
           
            }
        }

        // SI EL JUGADOR PIERDE, MOSTRAR MENU GAME OVER Y, ANIDADO, SI PULSA X, SE REINICIA EL JUEGO
        if (boolStart == true && boolGameOver == true)
        {
            menuFinal.SetActive(true);

            if (Input.GetKeyDown(KeyCode.X))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            } 
        }
 // IN  // G // A // M  //  E //
      
        // SI PULSA X EL MENU START SE DEBE ESCONDER
        if (boolStart==true && boolGameOver == false)
        {
            menuStart.SetActive(false);
            
            // MOVER OBSTACULOS POPO HACIA ABAJO
            for (int i = 0; i < obstaculos.Count; i = i + 10)
            {
                if (obstaculos[i].transform.position.y <= -3)
                {
                    int randomObstaX = Random.Range(-22, 22);
                    int randomObstacY = Random.Range(35, 70);
                    obstaculos[i].transform.position = new Vector3(randomObstaX, randomObstacY, 0);
                }
                obstaculos[i].transform.position = obstaculos[i].transform.position + new Vector3(0,-1) * Time.deltaTime * speed;
            }

            // MOVER OBSTACULO SALVADOR O FALSO
            for (int i = 0; i < obsFalsos.Count; i = i + 10)
            {
                if (obsFalsos[i].transform.position.y <= 3)
                {
                    obsFalsos[i].transform.position = new Vector3(8, 33 , 0);
                }
                obsFalsos[i].transform.position = obsFalsos[i].transform.position + new Vector3(0, -1) * Time.deltaTime * 2;
            }

            // MOVER OBSTACULO FUEGO 2 LEVEL
            for (int i = 0; i < obsFuego.Count; i = i + 10)
            {
                if (obsFuego[i].transform.position.y < -3)
                {
                    int randObsX = Random.Range(-23, 7);
                    int randObsY = Random.Range(45, 70);
                    obsFuego[i].transform.position = new Vector3(randObsX, randObsY, 0);
                }
                obsFuego[i].transform.position = obsFuego[i].transform.position + new Vector3(0, -1) * Time.deltaTime * speed;
            }

            // MOVER OBSTACULO ROCA  LEVEL2
            for (int i = 0; i < obsRoca.Count; i = i + 10)
            {
                if (obsRoca[i].transform.position.y < -3)
                {            
                    int randObsiX = Random.Range(-7, 23);
                    int randObsiY = Random.Range(50, 70);
                    obsRoca[i].transform.position = new Vector3(randObsiX, randObsiY, 0);              
                }
                obsRoca[i].transform.position = obsRoca[i].transform.position + new Vector3(0, -1) * Time.deltaTime * speed;
            }

        }
 // IN  // G // A // M  //  E //





    }










}
