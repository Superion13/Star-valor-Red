using UnityEngine;
using System.Collections;

public class spinr : MonoBehaviour
{
	public float speed = 50f;
		
		
	void Update ()
	{
		if (Input.GetKey(KeyCode.Q))
		transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}