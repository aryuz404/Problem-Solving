using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        MoveCircle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveCircle()
    {
        rb.AddForce(new Vector2(80, 15));
    }

}//class
