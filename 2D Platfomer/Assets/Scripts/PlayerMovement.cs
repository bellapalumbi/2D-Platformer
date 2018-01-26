using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D player_rb;
	public float thrust;
	

	void Start () {
		//rb.AddForce (transform.up * thrust);
	}
	

	void Update () {
		if (Input.GetKeyDown ("space") || Input.GetKeyDown( KeyCode.W) == true) {
			print("jump");
			Debug.DrawRay(transform.position, -Vector2.up, Color.cyan);
			if(Physics2D.Raycast(transform.position, -Vector2.up)) {
				Jump();
			}
		}
	}

	void Jump() {
		Debug.Log("jump");
		player_rb.AddForce(transform.up * thrust);
	}
	void MoveLeft() {
		
	}

	void MoveRight() {
		
	}

}
