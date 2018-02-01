using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

    public int playerSpeed = 10;
    public int playerJumpPower = 500;
    private bool facingRight = true;
    private float moveX;
    private bool grounded;

	
	// Update is called once per frame
	void Update () {
        PlayerMove();
	}

    void PlayerMove(){
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded == true){
            
            Jump();
        }
        //ANIMATIONS
        //PLAYER DIRECTION
        if(moveX < 0.0f) {
            GetComponent<SpriteRenderer>().flipX = true;
        }else if (moveX > 0.0f) {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        //PHYSICS
        if (grounded == true) {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Animator>().SetFloat("Speed", Mathf.Abs(moveX));
        }
    }

    void Jump(){
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        GetComponent<Animator>().SetTrigger("Jump");
        grounded = false;

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag == "Ground") {
            Debug.Log("Ground");
            grounded = true;
        } 
        
    }
}
