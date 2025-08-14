using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : MonoBehaviour
{

    private bool jumping;
    private Rigidbody2D rb;

    [SerializeField] private float jumpSpeed;
    [SerializeField] private GameObject gameover;
    [SerializeField] private AudioClip jumpSound, ponto, porrada;



    // Start is called before the first frame update
    void Start()
    {
        jumping = false;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Teclou o Espaço");
            jumping = true;
        }
    }

    void FixedUpdate()
    {
        if (jumping)
        {
            AudioController.instance.PlayAudioClip(jumpSound, false);
            rb.velocity = Vector2.up * jumpSpeed;//(0,1)*jumpSpeed
            jumping = false;
        }
    }

    void OnCollisionEnter2D()
    {
        Time.timeScale = 0f;
        gameover.SetActive(true);
        AudioController.instance.PlayAudioClip(porrada, false);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Score"))
        
        {
            AudioController.instance.PlayAudioClip(ponto, false);
            GameController.instance.IncreaseScore(1);
        }
    }

}

