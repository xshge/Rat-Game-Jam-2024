using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{   
    public float speed = 10f;
    public float jumpH = 15; 
    public float gravityScale = 4;
    public float fallGravityScale = 10; 
    AudioSource jumpSound;
    SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite Walk; 

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpSound = GetComponent<AudioSource>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {   rb.gravityScale = gravityScale; 
            jumpSound.Play();
           
            spriteRenderer.sprite = newSprite; 
            float jumpForce = Mathf.Sqrt(jumpH * (Physics2D.gravity.y * rb.gravityScale) * -2)* rb.mass;
           rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); 
            Debug.Log("force is " + jumpForce );
           //Debug.Log("it is pressed");
        }

        if (rb.velocity.y > 0 || rb.velocity.x > 0 || rb.velocity.x < 0 )
        {
            rb.gravityScale = gravityScale; 
        } else {
            rb.gravityScale = fallGravityScale; 
        }
        //ChangeSprite();
        //moving
        if(Input.GetKeyDown(KeyCode.D))
       {    spriteRenderer.sprite = Walk; 
            //Vector3 positionChange = new Vector3 (speed,0,0);
            //transform.position += positionChange* Time.deltaTime;

            rb.velocity = new Vector2(speed, 0f);
       }else if (Input.GetKey(KeyCode.A)) {
           //Vector3 positionChange = new Vector3 (-speed,0,0);
           //transform.position += positionChange* Time.deltaTime;

           rb.velocity = new Vector2(-speed, 0f);

       }
    }
    void ChangeSprite()
    {   if (Input.GetKeyDown(KeyCode.D))
        {   spriteRenderer.sprite = Walk; 
             Debug.Log("Changed Sprite");
        }
        spriteRenderer.sprite = newSprite; 
; 
    }
}
