using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{

    [SerializeField] private float speed;
    private bool yVariable;


    // Start is called before the first frame update
    void Start()
    {
        // yVariable = Random.Range(-1, 5) > 0;
        // if (yVariable)
        // {
        //     OscilateY();
        // }

        float randomY = Random.Range(-2f, 2f);
        transform.position = new Vector2(transform.position.x, randomY);
    }

    // Update is called once per frame


    // OscilateY()
    // {
    //     float newY = transform.position.y + (yVariable ? 0.15f : -0.15f);
    //     if (newY > 2 || newY < -2)
    //     {
    //         yVariable = !yVariable;
    //         newY = transform.position.y + (yVariable ? 0.15f : -0.15f);
    //     }
    //     transform.position = new Vector2(transform.position.x, newY);
    //     Invoke("OscilateY", 0.1f);
    // }

    void Update()
    {
        transform.position = new Vector2(
            transform.position.x - speed * Time.deltaTime,
            transform.position.y
        );
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("DestroyPoint"))
        {
            Destroy(gameObject);
        }
    }
}
