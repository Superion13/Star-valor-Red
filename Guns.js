#pragma strict
var cameraObject : GameObject;
var targetXRotation : float;
var targetYRotation : float;
var targetXRotationV : float;
var targetYRotationV : float;
var rotateSpeed : float;
var holdX : float;
var holdY : float;
var holdZ : float;
var holdDown : float; 
var aimSpeed : float;
var holdDownV : float ;
var aimingIsTrue : float; 
var zoomAngle : float; 
var fireRate : float;
var	waitTilFire : float; 
var bullet : GameObject;
var spawnBullet : GameObject; 

function Update () 
{
	if(Input.GetButton("Fire1"))
	{
		if(waitTilFire <=0)
			{
				if(bullet)
					{
						Instantiate(bullet, spawnBullet.transform.position, spawnBullet.transform.rotation);					
					}
				waitTilFire = 1;
			}
	}
	waitTilFire -= Time.deltaTime * fireRate;
	
	cameraObject.GetComponent(MouseLook).targetCamera = zoomAngle;
	if(Input.GetButton("Fire2"))
		{
			holdDown = Mathf.SmoothDamp(holdDown,0, holdDownV, aimSpeed);
			cameraObject.GetComponent(MouseLook).aimingTrue = aimingIsTrue;
		}
	else
		{
			holdDown = Mathf.SmoothDamp(holdDown,1, holdDownV, aimSpeed);
			cameraObject.GetComponent(MouseLook).aimingTrue = 1;
		}
	transform.position = cameraObject.transform.position + (Quaternion.Euler(0, targetYRotation, 0) * Vector3(holdDown * holdX, holdDown * holdY, holdDown * holdZ));
	targetXRotation = Mathf.SmoothDamp(targetXRotation, cameraObject.GetComponent(MouseLook).xRotation, targetXRotationV, rotateSpeed);
	targetYRotation = Mathf.SmoothDamp(targetYRotation, cameraObject.GetComponent(MouseLook).yRotation, targetYRotationV, rotateSpeed);
	
	transform.rotation = Quaternion.Euler(targetXRotation, targetYRotation, 0);
}