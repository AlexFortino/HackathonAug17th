using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movements : MonoBehaviour
{

    public float movespeed;
    public Rigidbody2D rb ;
    
    private bool facingup;

    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      movement.x =  Input.GetAxisRaw("Horizontal");
      movement.y= Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {


        rb.MovePosition(rb.position + movement * movespeed * Time.deltaTime);



    }

   

}
