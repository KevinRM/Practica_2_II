using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public void fire() {
		GetComponent<Rigidbody> ().velocity = transform.forward * 6;
		Destroy (gameObject, 5f);
	}
}
