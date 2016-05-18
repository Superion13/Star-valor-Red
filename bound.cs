using UnityEngine;
using System.Collections;

public class bound: MonoBehaviour
{
	void OnTriggerExit(Collider other)
	{
		Destroy(other.gameObject);
	}
}