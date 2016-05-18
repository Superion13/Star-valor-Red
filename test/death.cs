using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class death : MonoBehaviour {
	public int health = 20;
	public int damage = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider Other){
		//Instantiate (Explosion, transform.position, transform.rotation);
		health-=damage;
		if (health <= 0) {
			Application.LoadLevel ("title");
		}
	}
}