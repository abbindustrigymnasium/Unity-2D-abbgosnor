using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KalleMovement : MonoBehaviour
{

    public float MovementSpeed = 5f;  
    public float JumpForce = 1;
    public float DbJumpForce = 4;   
    public float MoveMultiply = 100f;
    public float DbJump = 0; 
    public Animator anim;
    public Rigidbody2D rb;
    public LayerMask groundLayers;
    float mx;
    
    public bool isGrounded = false;
    private bool isJumping = false;
    public bool JumpingA = false; 
    public bool DbJumpA = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f); //För att Kalle ska kunna hoppa och gå.
        transform.position += movement * Time.deltaTime * MovementSpeed;


        anim.SetBool("isJumping", isJumping);
        anim.SetFloat("Speed", movement.x);

        if (movement.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (movement.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
           isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - 0.5f, transform.position.y -0.7f),  
            new Vector2(transform.position.x + 0.5f, transform.position.y +0.2f), groundLayers);
    }


    void Jump(){
        mx = Input.GetAxis("Horizontal");
        var velocity2 = Mathf.Abs(rb.velocity.y);
        var velocity = GetComponent<Rigidbody2D>().velocity.y;      //Kod för att han bara ska kunna dubbel hoppa och inte mer.
        var JumpForceTrue = JumpForce * MoveMultiply;
        var DbJumpForceTrue = DbJumpForce * MoveMultiply;

        if(Input.GetKeyDown("w") && (DbJump > 0)&& !isGrounded){
        rb.velocity = new Vector2(rb.velocity.x, JumpForceTrue);
        DbJumpA = true;
        JumpingA = false;
        DbJump -= DbJump;
        }
        else if(Input.GetKeyDown("w") && isGrounded){
                rb.velocity = new Vector2(rb.velocity.x, DbJumpForceTrue);
                JumpingA = true;
                DbJump += 1;
           }

    }
    
}