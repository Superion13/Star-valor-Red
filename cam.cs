using UnityEngine;
using System.Collections;

public class cam : MonoBehaviour {
	public GameObject Player;
	public float rotateSpeed = 10;

	public float minAngle = 1;
	public float maxAngle = 360;


	void Update () {
		//Turret rotation and angle clamp
		if(Input.GetAxis("Mouse X") < 0) {
			Player.transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
		}
		if(Input.GetAxis("Mouse X") > 0) {
			Player.transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);
		}
		if(Input.GetAxis("Mouse Y") < 0) {
			Player.transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
		}
		if(Input.GetAxis("Mouse Y") > 0) {
			Player.transform.Rotate(0, 0, -rotateSpeed * Time.deltaTime);
		}

		transform.eulerAngles = new Vector3(0, 0, Mathf.Clamp (transform.eulerAngles.z, minAngle, maxAngle));
	}
}