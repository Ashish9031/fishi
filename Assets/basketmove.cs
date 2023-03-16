using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class basketmove : MonoBehaviour
{
    public float sd;
    Rigidbody2D bd;
    float a;
    Vector2 move;
    void Start()
    {
        sd = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        a = Input.GetAxis("Horizontal");
        move = new Vector2(x * speed, rb.velocity.y);
        sd.velocity = move;
    }
}