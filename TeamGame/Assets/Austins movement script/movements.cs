using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movements : MonoBehaviour
{

    public float movespeed;
    public Rigidbody rb ;
    float horizontal;
    float vertical;
    private bool facingright = true;
    private bool facingup;
    private float moveInput;
    private float moveInputy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontal  =  Input.GetAxisRaw("Horizontal");
       vertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {

        moveInput = Input.GetAxis("Horizontal");
        moveInputy = Input.GetAxis("Vertical");

        rb.velocity = new Vector3 (horizontal * movespeed, vertical * movespeed);

        if (facingright == false && moveInput < 0)
        {
            Flip();


        }
        else if (facingright == true && moveInput > 0)
        {

            Flip();

        }
        if (facingright == false && moveInputy < 0)
        {
            Flipy();


        }
        else if (facingright == true && moveInputy > 0)
        {

            Flipy();

        }




    }

    void Flip ( )
    {
        facingright = !facingright;
        
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        

        transform.localScale = Scaler;


    }
    void Flipy()
    {
        facingup = !facingup;

        Vector3 Scaler = transform.localScale;
        Scaler.x *= +1;


        transform.localScale = Scaler;


    }

}
