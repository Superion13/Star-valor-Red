using UnityEngine;
using System.Collections;

public class owlBulletCode : MonoBehaviour {

	public float speed = 10f;
	public Vector3 trajectory;
	public Rigidbody rb;
	GameObject owlBullet;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		trajectory = transform.forward * speed;

		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		
	}
	
	void FixedUpdate(){
		
		rb.AddForce (trajectory);
	}
	
	
	void OnCollisionEnter(Collision col){
		
		if (col.gameObject.tag == "Player") {
			Destroy(col.gameObject);
		}
	}
	
	
}
