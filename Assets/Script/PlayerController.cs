using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    //PlayerObjects
    public float moveSpeed = 3.5f;


    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(down))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }else if (Input.GetKey(up))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            
        }


        if (Input.GetKey(right))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.x);
        }
        else if (Input.GetKey(left))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.x);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.x);

        }
    }
   


}
