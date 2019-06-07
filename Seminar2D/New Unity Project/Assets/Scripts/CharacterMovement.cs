using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) //Control by keyboard with left arrow button
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0)); //Apply force on x axis
            GetComponent<SpriteRenderer>().flipX = false; // change facing direction
            GetComponent<Animator>().SetTrigger("Run"); // control animation with state machine
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed));
        }
    }

    void OnCollisionEnter2D(Collision2D collision) // Method for controlling collision events
    {
        //Destroy(collision.gameObject);
        Debug.Log(collision.gameObject.name);
    }
}
