#pragma strict
var lookSensitivity : float = 5;
var yRotation : float;
var xRotation : float;
var CurrentXRotation : float;
var CurrentYRotation : float;
var yRotationV : float;
var xRotationV : float;
var lookSmoothness : float = 0.1;

function Update ()
	{
		yRotation += Input.GetAxis("Mouse X") * lookSensitivity;
		xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
		
		xRotation = Mathf.Clamp(xRotation, -80, 100);
		
		CurrentXRotation = Mathf.SmoothDamp(CurrentXRotation, xRotation, xRotationV, lookSmoothness);
		CurrentYRotation = Mathf.SmoothDamp(CurrentYRotation, yRotation, yRotationV, lookSmoothness);
		
		transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
	}