using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(cc.isGrounded == true && cc.velocity.magnitude > 2f && audio.isPlaying == false)
        {
           // audio.volume = Random.Range(0.8f, 1);
            //audio.pitch = Random.Range(0.8f, 1.1f);
            //audio.Play();
        }
    }
}
