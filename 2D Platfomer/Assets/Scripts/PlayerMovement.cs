using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody2D rb;
	public float thrust;
	//private Vector2 = (10,10);

	void Start () {
		//rb.AddForce (transform.up * thrust);
	}
	

	void Update () {
		if (Input.GetKeyDown ("space") || Input.GetKeyDown(KeyCode.W)) {
			Debug.Log("jump pressed");
		}
	}

	void MoveLeft() {
		
	}

	void MoveRight() {
		
	}

}
