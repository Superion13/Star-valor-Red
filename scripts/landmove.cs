using UnityEngine;
using System.Collections;

public class landmove : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float speed = 20.0f * Time.deltaTime;

		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(0.0f, 0.0f, speed);
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(0.0f, 0.0f, -speed);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(-speed, 0.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(speed, 0.0f, 0.0f);
		}

	}
}