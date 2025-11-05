using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Vector2 velocity = Vector2.one;


    [SerializeField]
    float zigzagTime = 1f;

    [SerializeField]
    ZigZagDirection zigzagdirection;

    Rigidbody2D rigidBody;
    float timer;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        if (rigidBody == null)
        {
            Debug.Log("This object is missing a rigidbody!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(rigidBody == null)
        {
            return;
        }

        timer -= Time.deltaTime;
        ZigZagMovement();
    }

    void ZigZagMovement()
    {
        if(timer < 0)
        {
            if(zigzagdirection == ZigZagDirection.HORIZONTAL)
            {
                velocity = new Vector2(velocity.x, -velocity.y);
            }
            if (zigzagdirection == ZigZagDirection.VERTICAL)
            {
                velocity = new Vector2(-velocity.x, velocity.y);
            }


            timer = zigzagTime;
        }


        rigidBody.linearVelocity = velocity;
        
    }

    
}

public enum ZigZagDirection
{
    HORIZONTAL,
    VERTICAL
}