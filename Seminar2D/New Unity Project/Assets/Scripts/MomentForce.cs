using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentForce : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //simulate the tourque force (rotation)
        GetComponent<Rigidbody2D>().AddTorque(-speed);
    }
}
