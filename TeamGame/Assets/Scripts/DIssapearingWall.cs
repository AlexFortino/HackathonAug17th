using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIssapearingWall : MonoBehaviour
{

    public GameObject theObject;
    public GameObject Text1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && (theObject == null))
        {
            Destroy(gameObject);
            
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(Text1);
        }
    }
}
    
