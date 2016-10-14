using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {
	// Canvas update
	public delegate void ChangeInfoBalls();
	public static event ChangeInfoBalls InfoBalls;
	// Color balls
	public delegate void ChangeColorBalls(Color color);
	public static event ChangeColorBalls ColorBalls;

	private Color cyan = Color.cyan;
	private Color red = Color.gray;
	private Color white = Color.white;
	private Color pink = Color.magenta;
	private Color grey = Color.grey;
	private Color green = Color.green;

	public void changeColorBalls() {
		InfoBalls ();	// Call event
		//GameObject[] balls = GameObject.FindGameObjectsWithTag ("Ball");

		Color colorToApply = new Color();
		int number = Random.Range (0, 6);
		switch (number) {
		case 0:
			{
				colorToApply = cyan;
			}
			break;
		case 1:
			{
				colorToApply = red;
			}
			break;
		case 2:
			{
				colorToApply = white;
			}
			break;
		case 3:
			{
				colorToApply = pink;
			}
			break;
		case 4:
			{
				colorToApply = grey;
			}
			break;
		case 5:
			{
				colorToApply = green;
			}
			break;
		}

		ColorBalls (colorToApply);

		/*foreach (GameObject selected in balls) {
			Renderer rend = selected.GetComponent<Renderer> ();
			rend.material.color = colorToApply;
			selected.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 200, 0));
		}*/
	}
}
