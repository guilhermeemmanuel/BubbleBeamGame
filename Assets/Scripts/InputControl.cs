using UnityEngine;
using System.Collections;

public class InputControl : MonoBehaviour {

	public CanonControl spawnRight;
	public CanonControl spawnLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		

		if (Input.GetButtonDown ("Fire1")) {
			float mousex = (Input.mousePosition.x);
			float mousey = (Input.mousePosition.y);
			Vector2 mouseposition = Camera.main.ScreenToWorldPoint(new Vector2 (mousex,mousey));

			if (mouseposition.x < 0) {
				spawnLeft.SpawnBubble ();
			} else {
				spawnRight.SpawnBubble ();
			}



		}


		if (Input.GetKeyDown ("s")) {
			spawnLeft.SpawnBubble ();
		} else if (Input.GetKeyDown ("d")) {
			spawnRight.SpawnBubble ();
		}
	}
}
