using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour
{

    [SerializeField]
    float maxSpeed = 10f;
    [SerializeField]
    bool facingRight = true;
    [SerializeField]
    bool grounded = false;
    [SerializeField]
    float groundRadius = 0.2f;
    [SerializeField]
    Transform groundCheck;
    [SerializeField]
    LayerMask whatIsGround;
    [SerializeField]
    float jumpForce = 350f;
    [SerializeField]
    AudioClip soundJump;
    AudioSource m_sound;
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        m_sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        //control for jump
        if (grounded && Input.GetButtonDown("Jump"))
        {
            m_sound.PlayOneShot(soundJump);
            anim.SetBool("Ground", false);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }

    }



    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", grounded);

        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);



        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", GetComponent<Rigidbody2D>().velocity.y);


        GetComponent<Rigidbody2D>().velocity = new Vector3(maxSpeed * move, GetComponent<Rigidbody2D>().velocity.y);


        anim.SetFloat("Speed", Mathf.Abs(move));

        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }


    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }


        
}