using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMove : MonoBehaviour
{
    public GameObject objetoAMover;

    public Transform startPoint;
    public Transform endPoint;

    public float velocidad;

    private Vector2 moverHacia;

    void Start()
    {
        moverHacia = endPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        objetoAMover.transform.position = Vector2.MoveTowards(objetoAMover.transform.position, moverHacia, velocidad * Time.deltaTime);
        if(objetoAMover.transform.position == endPoint.position)
        {
            moverHacia = startPoint.position;
        }
        if (objetoAMover.transform.position == startPoint.position)
        {
            moverHacia = endPoint.position;
        }

    }





}

