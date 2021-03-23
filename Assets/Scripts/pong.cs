using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pong : MonoBehaviour
{
    // Start is called before the first frame update
   
    
        [SerializeField]
        float velocidade = 0.5f;

        [SerializeField]
        KeyCode Upkey = KeyCode.UpArrow;

        [SerializeField]
        KeyCode Downkey = KeyCode.DownArrow;

    // Update is called once per frame
    void Update()
    {
        /**
         * se tecla para cima premida
         * entao subir
         * senão se tecla para baixo
         * então descer
         */


        if (Input.GetKey(Upkey))
        {
            //transform.position =
            // transform.position + velocidade * Vector3.up;
            transform.position += velocidade * Vector3.up * Time.deltaTime;
            //Sobe

        } else if (Input.GetKey(Downkey))
        {
            //transform.position =
            // transform.position + velocidade * Vector3.down;
            transform.position += velocidade * Vector3.down * Time.deltaTime;
            //Desce
        }

        float cameraHeight = Camera.main.orthographicSize;
        float halfPaddleSize = 0.5f;


        //if (transform.position.y >= cameraHeight - halfPaddleSize)
        {
            //Na pratica o codigo abaixo faz
            //transform.position + velocidade = 3f - 0.5f
           // Vector3 positionAux = transform.position;
           // positionAux.y = cameraHeight - halfPaddleSize;
           // transform.position = positionAux;
        }
        //if (transform.position.y >= -cameraHeight + halfPaddleSize)
        {
            //Na pratica o codigo abaixo faz
            //transform.position + velocidade = -3f + 0.5f
           // Vector3 positionAux = transform.position;
          //  positionAux.y = -cameraHeight + halfPaddleSize;
            //transform.position = positionAux;
        }

        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(transform.position.y,
            -cameraHeight + halfPaddleSize,
            cameraHeight - halfPaddleSize);
        transform.position = positionAux;
    }
}
