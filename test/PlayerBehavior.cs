using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

	public float lookSensitivity=5f;
	private float xRot;
	private float yRot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Movement Code that utalizes the input function in unity referencing the horizontal to manipulate the x value on the players position and the veticle for the z

		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");



		transform.Translate(x,0f,z);

			
		//Player rotation code took me a while to realize that the mouse y would inflounce the horizontal rotation and vice versa

		xRot-= Input.GetAxis ("Mouse Y") * lookSensitivity;
		yRot+= Input.GetAxis ("Mouse X") * lookSensitivity;



		/*prevents player from doing backflips while looking up got code from youtube channel called penguin design
			limits the value of the xRot which essentially just limits how high up and low the player may look
		*/
	
		xRot = Mathf.Clamp (xRot, -80, 100);


			//actually does the rotation based off of xRot and yRot variables
		
			transform.rotation = Quaternion.Euler (xRot, yRot, 0f);



		//Awesome code that hides cursor and locks it in the middle of the screen helps a lot with rotation
		Screen.lockCursor = true;

	}
}
