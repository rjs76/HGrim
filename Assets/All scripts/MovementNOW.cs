﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementNOW : MonoBehaviour {
    private Rigidbody2D rb2d;
    public int speed;
    public float jump;
    bool OnGround = true;
    public Animator animator;
    //float horizontalmove=0f;

    public Transform spawnpoint;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
         //Horizontal Movement
        float movex = Input.GetAxisRaw("Horizontal");
        rb2d.velocity = new Vector2(movex * speed, rb2d.velocity.y);
        //animator
        animator.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));

        Debug.Log(animator.GetFloat("Speed"));

        animator.SetFloat("Jumping", Mathf.Abs(rb2d.velocity.y));

        if (Input.GetKeyDown(KeyCode.Space) && OnGround)
        {
            rb2d.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
            
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("platform"))
        {
            OnGround = true;
            animator.SetBool("IsJumping", true);
        }
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            respawn();
        }
        if (collision.gameObject.tag.Equals("Death"))
        {
            respawn();
        }
    }

   // public void OnLanding()
   // {
  //      animator.SetBool("IsJumping", false);
   //     OnGround = false;
  //  }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            animator.SetBool("IsJumping", false);
            OnGround = false;
        }
    }

    public void respawn()
    {
        this.transform.position = spawnpoint.position;

    }

}
