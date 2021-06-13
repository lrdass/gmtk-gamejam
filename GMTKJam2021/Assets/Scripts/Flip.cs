using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x < 0)
        {
            sr.flipX = true;
        }
        else
        {
            if (rb.velocity.x > 0)
            {
                sr.flipX = false;
            }
        }
    }
}
