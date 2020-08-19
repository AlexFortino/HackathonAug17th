using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot1Switching : MonoBehaviour
{
    public GameObject GlowStickItem;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Destroy(GlowStickItem);
        }
    }
}
