using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pato : MonoBehaviour
{

    private bool jumping;
    private Rigidbody2D rb;

    [SerializeField] private float jumpSpeed;


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
            rb.velocity = Vector2.up * jumpSpeed;//(0,1)*jumpSpeed
            jumping = false;
        }
    }

    void OnCollisionEnter2D(Collision collision){}

}

