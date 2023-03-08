using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(3f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
