using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Serialized Fields for attributes
    [SerializeField]
    float movementSpeed = 1f;

    //Variables used within this script
    Rigidbody2D rigidBody;
    Collider2D coll2D;

    Vector2 playerHalfSize = Vector2.zero;
    
    // Start is called before the first frame update
    void Start()
    {

        rigidBody = GetComponent<Rigidbody2D>();
        if(rigidBody == null)
        {
            Debug.Log("This object is missing a rigidbody!");
        }

        coll2D = GetComponent<Collider2D>();
        if(coll2D != null)
        {
            playerHalfSize = coll2D.bounds.extents;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidBody == null)
        {
            return;
        }

        Vector2 direction = Vector2.zero;

        float verticalBound = Camera.main.orthographicSize - playerHalfSize.y;
        float horizontalBound = Camera.main.orthographicSize * Camera.main.aspect - playerHalfSize.x;

        if (transform.position.y < verticalBound && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            direction.y = 1;
        } 
        if (transform.position.y > -verticalBound && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            direction.y = -1;
        } 
        if (transform.position.x < horizontalBound && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            direction.x = 1;
        }
        if (transform.position.x > -horizontalBound && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        {
            direction.x = -1;
        }

        rigidBody.linearVelocity = direction.normalized * movementSpeed;

    }


}
