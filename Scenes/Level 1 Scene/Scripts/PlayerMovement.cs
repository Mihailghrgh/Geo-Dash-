using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//template for future games in moving 2D objects 
public class PlayerMovement : MonoBehaviour
{
    public float speed;

    public Rigidbody2D rb;

    public float jump;

    public float move;

    private bool isJumping;

    public AudioSource AudioSource;


    private void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);

       
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 4000);
        }*/

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            AudioSource.Play();
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            this.isJumping = false;

        } 
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground" )
        {
            this.isJumping = true;

        }
    }

}
