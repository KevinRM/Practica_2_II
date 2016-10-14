using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberBalls : MonoBehaviour {
	private Text txt_available;
	private int ballsAvailables = 0;
	private Text txt_destroyed;
	private int ballsDestroyed = 0;

	void Start() {
		txt_available = GameObject.Find ("BallsAvailables").GetComponent<Text> ();
		txt_destroyed = GameObject.Find ("BallsDestroyed").GetComponent<Text> ();
		SceneControl.InfoBalls += numberBallsDestroyed;	// Add method to event
	}

	public void numberBallsAvailables(int number) {
		ballsAvailables += number;
		txt_available.text = "Bolas creadas: " + ballsAvailables;
	}

	public void numberBallsDestroyed() {
		ballsDestroyed++;
		txt_destroyed.text = "Bolas destruidas: " + ballsDestroyed;
	}
}
