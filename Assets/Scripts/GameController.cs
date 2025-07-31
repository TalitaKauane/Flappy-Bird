using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject message, pato;

    [SerializeField] private GameObject pipes, source;
    private float intervalo = 1f;

    private bool started;

    void Start()
    {
        started = false;
        InvokeRepeating("SpawnPipes", 0f, intervalo);
    }

    private void SpawnPipes()
    {
        if (!started) return;
        
        Instantiate(
            pipes,  //Istancia os pilares
            source.transform.position, //Na posição do objeto source
            Quaternion.identity //Com rotação padrão (sem rotação, identidade)
        );
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(message);
            pato.SetActive(true);
            started = true;
        }
    }
}