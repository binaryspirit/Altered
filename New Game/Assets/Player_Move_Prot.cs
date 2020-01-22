﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prot : MonoBehaviour
{
	public int playerSpeed = 5;
	public bool facingRight = true;
	public int playerJumpPower = 1250;
	public float moveX;
	public bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
   
    void PlayerMove(){
		//CONTROLS
		moveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown ("Jump") && isGrounded == true){
			Jump();
		}
    	//ANIMATIONS
    	//PLAYER DIRECTION
    	if (moveX > 0.0f && facingRight == false) {
    		FlipPlayer ();
    	}
    	else if (moveX < 0.0f && facingRight == true) {
    		FlipPlayer ();
    	}
    	//PHYSICS
    	gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump(){
    	//JUMPING CODE
    	GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
    	isGrounded = false;
    }

    void FlipPlayer(){
    	facingRight = !facingRight;
    	Vector2 localScale = gameObject.transform.localScale;
    	localScale.x *= -1;
    	transform.localScale = localScale;
    }
    void OnCollisionEnter2D(Collision2D col){
    	if (col.gameObject.tag == "ground"){
    		isGrounded = true;
    	}
    }
    private void OnTriggerEnter2D(Collider2D other){
    	if(other.gameObject.CompareTag("weed")){
    		Destroy(other.gameObject);
    	}
    }

}
