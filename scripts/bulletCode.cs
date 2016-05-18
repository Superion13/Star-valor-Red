using UnityEngine;
using System.Collections;

public class bulletCode : MonoBehaviour {
	public float speed;
	public Vector3 trajectory;
	public Rigidbody rb;
	GameObject bullet;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		trajectory = transform.forward * speed;
	
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (trajectory);
	
	}
	void OnCollisionEnter(Collision col){
		Destroy (gameObject);
	}
}
