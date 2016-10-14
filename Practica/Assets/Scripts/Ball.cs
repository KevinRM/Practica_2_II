using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	void Start() {
		SceneControl.ColorBalls += changeColor;		// Add to event
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			SceneControl.ColorBalls -= changeColor;		// Delete from event
			GameObject.Find ("ScriptContainer").GetComponent<SceneControl> ().changeColorBalls ();
			Destroy (gameObject);
		}
	}

	private void changeColor(Color color) {
		Renderer rend = GetComponent<Renderer> ();
		rend.material.color = color;
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 200, 0));
	}
}
