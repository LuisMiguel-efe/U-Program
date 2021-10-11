using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    ///SONIDOS DEL JUGADOR
    public AudioClip soundJump;
    public AudioClip soundMierdita;
    public AudioClip soundOuh;
    public AudioClip soundGameOver;
    //    //     //    //

    /// BOOL DE TOCAR EL SUELO
    private bool Grounted;
    //    //     //    //

    /// VARIABLES PLAYER MOVE
    private float horizontal;
    public float fuerzaSalto;
    //    //     //    //

    public MoverCielo gamemanager;
    private Rigidbody2D Rigidbody2D; // VARIABLE QUE DETECTA EL SUELO RIGIDO
    private Animator animator;
    //
    public static bool muerteExterior = false;
    
    void Start()
    {
        /// INICIAR LOS COMPONENTES DE ANIMACION Y GRAVEDAD
        animator = GetComponent<Animator>();
        Rigidbody2D = GetComponent<Rigidbody2D>();
       
        //   //   //    //
    }

    // Update is called once per frame
    void Update()
    {
        //MOVE IZQUIERDA DERECHA
        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetBool("estaCorriendo", horizontal != 0);
       
        if (horizontal < 0.0f)
        {
            transform.localScale = new Vector3(-0.25f, 0.25f, 0);
        }
        else if (horizontal > 0.0f) transform.localScale = new Vector3(0.25f, 0.25f,0);

        //HACER QUE JUANITO SOLO SALTE UNA VEZ
        Debug.DrawRay(transform.position, Vector2.down , Color.red);
        if (Physics2D.Raycast(transform.position, Vector2.down, 1))
        {
            Grounted = true;

        }
        else Grounted = false;

        // JUANITO SALTA
        if (Input.GetKeyDown(KeyCode.W) && Grounted && Time.timeScale == 1)
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundJump);
            animator.SetBool("estaSaltando", true);
            Rigidbody2D.AddForce(Vector2.up * fuerzaSalto);
        }
        //
        if(muerteExterior == true)
        {
            muerteExterior = false;
            Camera.main.GetComponent<AudioSource>().Stop();

            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundMierdita);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundOuh);

            gamemanager.boolGameOver = true;
            animator.SetBool("estaMuerto", true);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundGameOver);
        }



    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //HACE QUE EL PLAYER VUELVA A CORRER CADA QUE TOQUE EL SUELO
        if (collision.gameObject.tag == "Suelo")
        {

            animator.SetBool("estaCorriendo", false);
            animator.SetBool("estaSaltando", false);
        }
        if (collision.gameObject.tag == "PlataformaMovible")
        {
            transform.parent = collision.transform;

            animator.SetBool("estaCorriendo", false);
            animator.SetBool("estaSaltando", false);
        }


        //MUERTE DEL JUGADOR POR OBSTACULOS
        if (collision.gameObject.tag == "Mierdita")
        {
            Timer.timeActive = false; //Detener tiempo

            Camera.main.GetComponent<AudioSource>().Stop();

            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundMierdita);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundOuh);

            gamemanager.boolGameOver = true;
            animator.SetBool("estaMuerto", true);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundGameOver);
        }
        


    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlataformaMovible")
        {
            transform.parent = null;

        }
    }





    private void FixedUpdate() //JUANITO SE MUEVE HORIZONTALMENTE IZQUIERDA DERECHA
    {
        Rigidbody2D.velocity = new Vector2(horizontal*7, Rigidbody2D.velocity.y);
       
    }
    //FUNCION QUE HACE DESAPARECER A JUANITO DESPUES DE MORIR
    public void FadeJuanito()
    {
        Destroy(gameObject);
    }





}
