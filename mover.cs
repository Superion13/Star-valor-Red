using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour
{
	public float speed;
	
	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
	void OnCollisionEnter ()
	{
		Destroy (gameObject);
	}
}