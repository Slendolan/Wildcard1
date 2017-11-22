using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;

    Animator theanimator;
    public bool isMoving;

    /*
    private bool IsMoving()
    {
        if (GetComponent<Rigidbody2D>().velocity.x != 0)
            return true;
        else
            return false;
    }
    */

    // Use this for initialization
    void Start () {
        theanimator = gameObject.GetComponent<Animator>();
        isMoving = true;
    }
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKeyDown (KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
        }

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        /*
        if(GetComponent<Rigidbody2D>().velocity.x != 0)
            isMoving = true;
        else
            isMoving = false;
        */

        theanimator.SetBool(123, true);
    }
    
}

