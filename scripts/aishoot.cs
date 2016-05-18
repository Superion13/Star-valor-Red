using UnityEngine;
using System.Collections;

public class aishoot: MonoBehaviour
{
	public float speed = 8f; 
	public float countdown = 3.0f;
	public GameObject Shot;
	public Transform ShotSpawn;
	private float nextFire;
	public float fireRate;


	void Update ()
	{
		countdown -= Time.deltaTime;
		if(countdown <= 10.0f)
			nextFire = Time.time + fireRate;
		Instantiate (Shot, ShotSpawn.position, ShotSpawn.rotation);

		if(Input.GetKey(KeyCode.RightArrow))
			transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
	}   
}