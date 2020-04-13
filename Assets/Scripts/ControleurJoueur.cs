using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControleurJoueur : MonoBehaviour
{

    public Rigidbody2D rb;
    public float vitesse;
    public float maxJump;
    private bool isGrounded = false;
    public static bool gameOver = false;


    void Start()
    {
        rb.velocity += new Vector2(vitesse, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            Jump();
        }
        

    }

    void Jump()
    {
        rb.velocity += new Vector2(0, maxJump);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("covid19"))
        {
            Destroy(gameObject);
            gameOver = true;
        }
        if (col.gameObject.CompareTag("coin"))
        {
            CoinBehavior.value += 1; ;
        }
    }
}

