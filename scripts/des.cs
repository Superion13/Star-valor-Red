using UnityEngine;
using System.Collections;

public class des : MonoBehaviour{
	//public GameObject Explosion;
	public int scoreValue;
	public GameController gameController;
	public int health = 20;
	public int damage = 5;
	
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController> ();
		}
		if (gameControllerObject == null)
		{
			Debug.Log ("Cannot find GameController script");
		}
	}

	void OnTriggerEnter(Collider Other){
		//Instantiate (Explosion, transform.position, transform.rotation);
		health-=damage;
		if (health <= 0) {
			//audioo.PlayOneShot(exp);
			//audioSource = GetComponent<AudioSource>();
			//audioSource.clip = exp;
			//audioSource.Play();
			Destroy (gameObject);
//			gameController.AddScore (scoreValue);
			Destroy(Other.gameObject);
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter1 (Collider Other)
	{
		//AudioSource audio = GetComponent<AudioSource> ();
		//audio.Play ();
	}
}