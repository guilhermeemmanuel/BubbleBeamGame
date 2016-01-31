using UnityEngine;
using System.Collections;

public class RingControl : MonoBehaviour {

	public GameControl game;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "StickCenter") {
			game.addScore (10);
		}
	}

}
