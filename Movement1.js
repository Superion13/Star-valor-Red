#pragma strict
var playerAcceleration : float = 500;
var cameraObject : GameObject;
var maxSpeed : float = 20;
var horizontalMovement : Vector2;
var deaceleration : float;
var deacelerationX : float;
var deacelerationZ : float;
var jumpSpeed : float = 20;
var maxSlope : float = 60;
var grounded : boolean = false;

function Update () 
	{
		horizontalMovement = Vector2(GetComponent.<Rigidbody>().velocity.x,GetComponent.<Rigidbody>().velocity.z);
		if (horizontalMovement.magnitude > maxSpeed)
			{
				horizontalMovement = horizontalMovement.normalized;
				horizontalMovement *= maxSpeed;
			}
		GetComponent.<Rigidbody>().velocity.x = horizontalMovement.x;
		GetComponent.<Rigidbody>().velocity.z = horizontalMovement.y;
		
		if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
			{
				GetComponent.<Rigidbody>().velocity.x = Mathf.SmoothDamp(GetComponent.<Rigidbody>().velocity.x,0,deacelerationX, deaceleration);
				GetComponent.<Rigidbody>().velocity.z = Mathf.SmoothDamp(GetComponent.<Rigidbody>().velocity.z,0,deacelerationZ, deaceleration);
			}
		transform.rotation = Quaternion.Euler(0, cameraObject.GetComponent(MouseLook).CurrentYRotation,0);		
		GetComponent.<Rigidbody>().AddRelativeForce(Input.GetAxis("Horizontal")*playerAcceleration * Time.deltaTime,0,Input.GetAxis("Vertical")*playerAcceleration * Time.deltaTime);
		if (Input.GetButtonDown("Jump")&& grounded)
			{
				GetComponent.<Rigidbody>().AddForce(0,jumpSpeed,0);
			}
	}
function OnCollisionStay(collision : Collision)
	{
		for(var contact : ContactPoint in collision.contacts)
			{
				if (Vector3.Angle(contact.normal, Vector3.up) < maxSlope)
					{
						grounded = true;
					}
			}	
	}
function OnCollisionExit()
	{
		grounded = false;	
	}	
	