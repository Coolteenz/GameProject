using UnityEngine;
using System.Collections;

public class PlayerControllerScript : MonoBehaviour
{

    [SerializeField]
    float maxSpeed =10f;
    [SerializeField]
    bool facingRight = true;
  

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

    }


    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", GetComponent<Rigidbody2D>().velocity.y);


        GetComponent<Rigidbody2D>().velocity = new Vector3(maxSpeed * move, GetComponent<Rigidbody2D>().velocity.y);


        //Horizontal is used to start the walking animation
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