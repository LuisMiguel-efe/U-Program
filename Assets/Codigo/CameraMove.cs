using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject Juanito;  // REFERENCIA PLAYER
    
    void Update()
    {
        if (Juanito != null)
        {
            Vector3 position = transform.position;
            position.x = Juanito.transform.position.x;
            transform.position = position;
            Vector3 subida = transform.position;
            subida.y = Juanito.transform.position.y;
            transform.position = subida;
        }
    }
}
