using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoreBalls : MonoBehaviour {
	public GameObject ball;
	private NumberBalls numberBallsAvailables;

	void Start() {
		numberBallsAvailables = GameObject.Find ("ScriptContainer").GetComponent<NumberBalls> ();
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "Bullet") {
			int numberBalls = Random.Range (1, 15);
			for (int i = 0; i < numberBalls; i++) {
				GameObject inst1 = (GameObject)Instantiate (ball);
				inst1.transform.position = new Vector3 (3, 4, Random.Range (-3, 4));
				GameObject inst2= (GameObject)Instantiate (ball);
				inst2.transform.position = new Vector3 (-3, 4, Random.Range (-3, 4));
				GameObject inst3 = (GameObject)Instantiate (ball);
				inst3.transform.position = new Vector3 (Random.Range (-3, 4), 4, 3);
				GameObject inst4 = (GameObject)Instantiate (ball);
				inst4.transform.position = new Vector3 (Random.Range (-3, 4), 4, -3);
			}
			numberBallsAvailables.numberBallsAvailables (numberBalls * 4);
		}
	}
}
