using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour
{
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
            return;
       transform.position = Vector3.up * speed * Input.GetAxisRaw("Vertical");
       print("is it working");
    }
}
