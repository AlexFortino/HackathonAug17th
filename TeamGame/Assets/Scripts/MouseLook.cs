using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Sensitivity of mouse
    public float mouseSensitivity = 100f;

    //Variable of entire player
    public Transform playerBody;

    //X rotation variable
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Keep cursor in the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Variables
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Y axis camera rotation
        xRotation -= mouseY;

        //Stopping camera from looking behind
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Y axis camera rotation
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //X axis player rotation
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
