using UnityEngine;
using System.Collections;

public class aifollow : MonoBehaviour {
	public Transform target;
	public Transform myTransform;
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
		transform.Translate (Vector3.forward * 5 * Time.deltaTime);
	}
}
