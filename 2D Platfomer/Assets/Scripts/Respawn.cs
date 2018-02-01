using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	
	// Update is called once per frame
	void LateUpdate () {
		if (gameObject.transform.position.y < -4) {
			gameObject.transform.position = new Vector2(-1.5f,0);
		}
	}
}
