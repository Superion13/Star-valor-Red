using UnityEngine;
using System.Collections;

public class owlCode : MonoBehaviour {


	Rigidbody rb;
	GameObject player;
	public GameObject bullet;
	GameObject owlBullet;
	public Transform playerLocation;
	public Transform owlBulletSpawn;

	// Use this for initialization
	public void fire(){

		if (owlBullet==null) {
			owlBullet = Instantiate (bullet, owlBulletSpawn.position, owlBulletSpawn.rotation) as GameObject;
		}
	}
	void Start () {
		rb = GetComponent<Rigidbody> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		//Invoke("fire",2);
	//	InvokeRepeating ("fire", 2, 2);



	}
	
	// Update is called once per frame
	void Update () {
	
		}
	void OnTriggerStay(Collider player) {
		transform.LookAt(playerLocation);

		InvokeRepeating ("fire", 1, 1);
		
		Destroy(owlBullet,20f);	
		
		if (transform.Find ("Npc Cruiser") == null) {
			Destroy(this);
		}
		//owlBullet = Instantiate(bullet,transform.position,transform.rotation) as GameObject;





	}

	/*void shoot(){
		Invoke("fire",2);
		Debug.Log ("responding");
	}
*/
}