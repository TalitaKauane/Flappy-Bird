using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 0f, intervalo);
    }

    private void SpawnPipes()
    {
        Instantiate(
            pipes,  //Istancia os pilares
            source.transform.position, //Na posição do objeto source
            Quaternion.identity //Com rotação padrão (sem rotação, identidade)
        );
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}