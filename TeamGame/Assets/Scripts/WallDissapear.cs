using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDissapear : MonoBehaviour
{
    public GameObject gameObject2;
    public GameObject theObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && (theObject == null))
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
   
}
