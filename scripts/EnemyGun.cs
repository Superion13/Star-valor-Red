using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {
	public GameObject EnemyBulletGo;

	// Use this for initialization
	void Start () {
		Invoke("FireEnemyBullet", 4f);

	}

	// Update is called once per frame
	void Update () {

	}

	void FireEnemyBullet()
	{
		GameObject playerShip = GameObject.Find ("Lplayer");

		if(playerShip != null) 
		{
			GameObject bullet = (GameObject)Instantiate (EnemyBulletGo);
			bullet.transform.position = transform.position;
			Vector3 direction = playerShip.transform.position - bullet.transform.position;
			bullet.GetComponent<EnemyBullet>().SetDirection(direction);
			Invoke ("FireEnemyBullet", 4f);
		}
	}
}