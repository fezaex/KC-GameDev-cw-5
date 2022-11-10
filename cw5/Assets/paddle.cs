using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = this,Getcomponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void fixedUpdate()
    {
        rb.velocity = new Vector2(input.Getaxis("horizontal"), 0f);
    }
}
