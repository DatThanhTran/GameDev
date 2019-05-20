using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public Vector2 newPos; // Declare variable for new position with type Vector2 (x:float, y:float)

    // Start is called before the first frame update
    void Start()
    {
        newPos = Vector2.zero; // Init the vector with zeros: x=0, y=0
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = newPos; // Change position on runtime when click Play
        Debug.Log(newPos); //Log for debug the new position values
    }
}
