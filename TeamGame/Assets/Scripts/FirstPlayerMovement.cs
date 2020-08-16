using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPlayerMovement : MonoBehaviour
{
    //Refering to the character controller
    public CharacterController controller;

    //Movement speed
    public float firstSpeed = 12f;

    //Gravity
    public float gravity = -10f;

    //Desired jump height
    public float jumpHeight = 3f;

    //Ground variables
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    //Water variables
    public Transform waterCheck;
    public float waterDistance = 0f;
    public LayerMask waterMask;

    //Storing velocity
    Vector3 velocity;

    //Ground check variables
    bool isGrounded;

    //Water check variables
    bool isWater;

    //# of coins
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        //Reseting score
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //Seeing if the player is grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //Seeing if the player is in water
        isWater = Physics.CheckSphere(waterCheck.position, waterDistance, waterMask);

        //Keeping player grounded
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //Keeping player afloat
        if (isWater && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        //Getting Data
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Getting inputs for movement
        Vector3 move = transform.right * x + transform.forward * z;

        //Movement
        controller.Move(move * firstSpeed * Time.deltaTime);

        //Jumping
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Calculating velocity
        velocity.y += gravity * Time.deltaTime;

        //Gravity/falling
        controller.Move(velocity * Time.deltaTime);
    }

    //Coin Code
    void OnTriggerEnter(Collider other)
    {
        //Coin detector
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            score += 1;
            Debug.Log("Score is " + score);
        }
    }
}
