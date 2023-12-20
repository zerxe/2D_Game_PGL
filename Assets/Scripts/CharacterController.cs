using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float fuerzaSalto = 2 ;
    public float velocidad =  1 ;

    private Rigidbody2D rb;
    private Animator animator;
    private float horizontal;
    private float vertical;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");




        if (horizontal < 0.0f){
            rb.velocity = new Vector2 (-velocidad, rb.velocity.y);   
        } else if (horizontal > 0.0f){
            rb.velocity = new Vector2(velocidad, rb.velocity.y);
        }
        else {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.W) && CheckGround.isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
        }
        
    }

 


}
