using UnityEngine;
using System.Collections;

public class basicMovement : MonoBehaviour {

	float gravity = 0.1f;
	float jumpSpeed = 10.0f;

	float dragLevel = 0.90f;
	float moveSpeed = 8.0f;

	bool isJumping = false;
	bool doubleJump = false;
	bool hasDoubleJumped = false;
	bool glider = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Enable powers
		if (Input.GetKeyDown("1")){
			if (doubleJump) {
				doubleJump = false;
				print ("Double Jump disabled");
			} else {
				doubleJump = true;
				print ("Double Jump enabled");
			}
		}

		if (Input.GetKeyDown("2")){
			if (glider) {
				glider = false;
				print ("Glider disabled");
			} else {
				glider = true;
				print ("Glider enabled");
			}
		}

		//If glider is enabled and player is falling, lower gravity
		if (glider && GetComponent<Rigidbody2D> ().velocity.y < 0) {
			GetComponent<Rigidbody2D> ().gravityScale = 0.1f;
		} else {
			GetComponent<Rigidbody2D> ().gravityScale = 2f;
		}
		//If pressing jump key
		if (Input.GetKeyDown ("w")) {
			//If not currently jumping, jump and set isJumping to true
			if (!(isJumping)) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpSpeed);
				isJumping = true;
				//If double jump power is enabled
			} else if (doubleJump) {
				//If player has not yet double jumped, allow one more jump
				if (!(hasDoubleJumped)) {
					GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpSpeed);
					hasDoubleJumped = true;
				}
			}
		}
		if (Input.GetKey ("a")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-(moveSpeed), GetComponent<Rigidbody2D> ().velocity.y);
		} else if (Input.GetKey ("d")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ((GetComponent<Rigidbody2D> ().velocity.x * dragLevel), GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
	 
	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Ground") {
			isJumping = false;
			hasDoubleJumped = false;
		}
	}	
}
