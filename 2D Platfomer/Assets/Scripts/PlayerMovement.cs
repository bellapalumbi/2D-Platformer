using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D player_rb;
	public float jumpThrust = 180;
	public float moveThrust;

	public Vector2 blinkVelocity;
//	public float speedMultiplier = 10;

	public RaycastHit2D hit;
	public SpriteRenderer spriteRenderer;
	

	void Start () {
		player_rb = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		moveThrust = 10;
	}
	

	void Update () {
		if (Input.GetKeyDown ("space") || Input.GetKeyDown( KeyCode.W) == true) { //if space or w pressed
			print("jump");
			//Debug.DrawRay(new Vector2(transform.position.x, transform.position.y-.2f), -Vector2.up, Color.cyan);
			hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y-0.2f), -Vector2.up,0.1f);
				//Send a raycast with a length of 0.1 from just below the player's position downward (opp of up)
				//and record what it hits in 'hit', a bool. 
			if (hit.transform != null) { //if hit is not null
					//Debug.Log(hit.transform.gameObject);
				if(hit.transform.gameObject.tag == "Jumpable") {
					Jump();
						//if the object hit has the tag "Jumpable, then run Jump()
				}
			}
		}

		if (Input.GetKey(KeyCode.A)) {
			//print("A pressed");
			blinkVelocity = new Vector2(-1,0);
			MoveLeft();
		}

		if (Input.GetKey(KeyCode.D)) {
			blinkVelocity = new Vector2(1,0);
			MoveRight();
		}

	}

	void Jump() {
		Debug.Log("jump");
		player_rb.AddForce(transform.up * jumpThrust);
	}
	void MoveLeft() {
		Debug.Log( "Move Left called");
		//player_rb.MovePosition(player_rb.position + blinkVelocity * Time.deltaTime*2);
		player_rb.AddForce(new Vector2(-1, 0) * moveThrust);
		spriteRenderer.flipX = false;
	}

	void MoveRight() {
		player_rb.AddForce(new Vector2(1,0) * moveThrust);
		spriteRenderer.flipX = true;
	}

}
