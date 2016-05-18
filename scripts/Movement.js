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
var jumpControl : float = 0.01;

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
		
		if (grounded)
			{
				GetComponent.<Rigidbody>().velocity.x = Mathf.SmoothDamp(GetComponent.<Rigidbody>().velocity.x,0,deacelerationX, 0);
				GetComponent.<Rigidbody>().velocity.z = Mathf.SmoothDamp(GetComponent.<Rigidbody>().velocity.z,0,deacelerationZ, 0);
			}
			
		transform.rotation = Quaternion.Euler(0, cameraObject.GetComponent(MouseLook).CurrentYRotation,0);		
		GetComponent.<Rigidbody>().AddRelativeForce(Input.GetAxis("Horizontal")*playerAcceleration * Time.deltaTime,0,Input.GetAxis("Vertical")*playerAcceleration * Time.deltaTime);
		
		if (grounded)
			{
				GetComponent.<Rigidbody>().AddRelativeForce(Input.GetAxis("Horizontal") * playerAcceleration * Time.deltaTime, 0 , Input.GetAxis("Vertical") * playerAcceleration * Time.deltaTime);
			}
			else
			{
				GetComponent.<Rigidbody>().AddRelativeForce(Input.GetAxis("Horizontal") * playerAcceleration * jumpControl * Time.deltaTime, 0 , Input.GetAxis("Vertical") * playerAcceleration * jumpControl * Time.deltaTime);
			}
		if(Input.GetButtonDown("Jump") && grounded)
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
	