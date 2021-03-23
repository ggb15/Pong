using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    bool bolaFoiLancada = false;

    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(WaitToDisplay());        
        
    }

    // Update is called once per frame
    public IEnumerator WaitToDisplay()
    {
        if (bolaFoiLancada == false)
        {
            yield return new WaitForSeconds(2f);
            GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitSphere;
            bolaFoiLancada = true;

        }





    }
}    
        
    


        //if(bolaFoiLancada == false)

// tempoDecorrido += Time.deltaTime;
//if(tempoDecorrido >= tempoDeEspera)

  // GetComponent<Rigidbody2D>().velocity = velocidade + Random.onUnitSphere;   bolaFoiLancada = true;



