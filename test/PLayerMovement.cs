using UnityEngine;
using System.Collections;

public class PLayerMovement : MonoBehaviour {

	private  float speed=5f;
	public GameObject camera;
	private Rigidbody rb;
	Vector3 force;
	private bool isJumping;
	private float jumpHeight=200f;

	void Start(){
	
		rb = GetComponent<Rigidbody> ();
	
	}


	void Update () {

		//Movement Code that utalizes the input function in unity referencing the horizontal to manipulate the x value on the players position and the veticle for the z

		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Vector3 moveX = transform.right * x;
		Vector3 moveZ = transform.forward * z;


		 force = (moveX + moveZ).normalized * speed;  


		if (isJumping == true) {
		
			if (Input.GetKeyDown (KeyCode.Space)) {
			
				rb.AddForce (Vector3.up * jumpHeight);
			}
		}








	}

	void OnCollisionExit(Collision col){
	
		if (isJumping) {
			isJumping = false;
		}
	

	}

	void OnCollisionStay(Collision col){
	
		isJumping = true;
	}

	void FixedUpdate() {
		//Was going to use "transform.Translate (force);" Until I saw I was going through other objects

		rb.MovePosition (rb.position + force * Time.deltaTime);
		

		
	}



}
