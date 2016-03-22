using UnityEngine;
using System.Collections;

public class RingControl : MonoBehaviour {

	public GameControl game;

	Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		body.AddForce (new Vector2 (0, Input.acceleration.x));


	}

	public void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "StickCenter") {
			game.addScore (10);
		}
	}

}
