using UnityEngine;
using System.Collections;

public class Fie : MonoBehaviour {
	public float speed;
	public GameObject Shot;
	public Transform ShotSpawn;
	private float nextFire;
	public float fireRate;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate (Shot, ShotSpawn.position, ShotSpawn.rotation);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
	}
}
