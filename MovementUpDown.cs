using UnityEngine;
using System.Collections;

public class MovementUpDown : MonoBehaviour {
    public Rigidbody2D rigidBody;
    public float moveSpeed;
    public bool hittingwall;
    public bool hittingwall2;
    public Transform wallcheck;
    public Transform wallcheck2;
    public float wallcheckradius;
    public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}

	
	// Update is called once per frame
	void Update () { 
        rigidBody.velocity = new Vector2(rigidBody.velocity.x, moveSpeed);

        hittingwall = Physics2D.OverlapCircle(wallcheck.position, wallcheckradius, whatIsGround);
        hittingwall2 = Physics2D.OverlapCircle(wallcheck2.position, wallcheckradius, whatIsGround);
        if (hittingwall == true)
        {         
            moveSpeed = 3;
        }
        if(hittingwall2 == true)
        {
            moveSpeed = -3;
        }
        

    }
}
