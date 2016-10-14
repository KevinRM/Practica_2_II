using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class PlayerShoot : MonoBehaviour {
	public GameObject bullet;	// Prefab
	private GameObject bull; 	// Object instanciated
	private GameObject cam;

	void Start() {
		cam = GameObject.Find ("Main Camera");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			bull = (GameObject)Instantiate (bullet);
			Physics.IgnoreCollision (GetComponent<Collider> (), bull.GetComponent<Collider> ());
			bull.transform.Rotate (new Vector3 (cam.transform.localEulerAngles.x, transform.localEulerAngles.y, 0));
			bull.GetComponent<Bullet> ().fire ();
		}
	}
}
