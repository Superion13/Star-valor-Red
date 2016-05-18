using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	public float lookSensitivity = 5f;
	public float xRot;
	public float yRot;
	public float current_xRot;
	public float current_yRot;
	public float smoothness= 0.1f;
	private float xRotV;
	private float yRotV;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		xRot -= Input.GetAxis ("Mouse Y") * lookSensitivity;
		yRot += Input.GetAxis ("Mouse X") * lookSensitivity;

		xRot = Mathf.Clamp (xRot, -00, 260);

		transform.rotation = Quaternion.Euler (0f, yRot, 0f);
		Camera.main.transform.localRotation= Quaternion.Euler (xRot,0f,0f);
		//Screen.lockCursor = true;
	}
}