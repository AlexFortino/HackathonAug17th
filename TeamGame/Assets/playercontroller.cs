using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public int speed = 5;
    public float jumpforce = 10;
    public float howmanyjumps = 1;
    float horizontal;
    float vertical;

    Camera cam;

    Rigidbody rb;


    bool isjumping = false;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
    }
    void LateUpdate()
    {
        horizontal += Input.GetAxis("Mouse X");
        vertical -= Input.GetAxis("Mouse Y");
        vertical = Mathf.Clamp(vertical, -30, 60);
        cam.transform.eulerAngles = new Vector3(vertical, horizontal, 0f);
        transform.eulerAngles = new Vector3(0, horizontal, 0);

    }
    // Update is called once per frame
    void Update()
    {
    


        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
}
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
}
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.back * speed * Time.deltaTime);
}
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
                }

        if (Input.GetButtonDown("Jump") && isjumping == false){



            isjumping = true;
                rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);


            

        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("ground beef"))
        {

            isjumping = false;
        }


    }
}
