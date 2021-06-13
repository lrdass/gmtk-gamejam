using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float inputX;
    public Rigidbody2D rb;
    public float JumpForce;
    public Transform FeetPosition;
    public LayerMask Ground;
    bool IsGrounded;
    public float GroundCheckRadius;
    public float JumpTimer;
    float f;
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (inputX != 0)
        {
            rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
        }
        IsGrounded = Physics2D.OverlapCircle(FeetPosition.position, GroundCheckRadius, Ground);
        inputX = Input.GetAxis("Horizontal");


    }

    private void Update()
    {

        f -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            if (f <= 0 && IsGrounded)
            {
                rb.velocity = Vector2.up * JumpForce;
                f = JumpTimer;

            }

        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spikes"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
