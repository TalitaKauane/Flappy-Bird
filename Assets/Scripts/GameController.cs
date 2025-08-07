using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject message, pato;
    [SerializeField] private GameObject pipes, source;
    [SerializeField]private Text scoreText;
    private float intervalo = 1f;
    private bool started;
    public static GameController instance;
    private int score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

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

    public void IncreaseScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }

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