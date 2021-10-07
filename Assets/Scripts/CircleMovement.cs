using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveCircle();
    }

    void MoveCircle()
    {
        Vector2 velocity = rb.velocity;

        if(Input.GetKey(KeyCode.W))
        {
            velocity.y = speed;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            velocity.y = -speed;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            velocity.x = speed;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            velocity.x = -speed;
        }
        else
        {
            velocity.x = 0.0f;
            velocity.y = 0.0f;
        }

        rb.velocity = velocity;
    }

}//class
