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

		if (Input.GetKeyDown ("s")) {
			spawnLeft.SpawnBubble ();
		} else if (Input.GetKeyDown ("d")) {
			spawnRight.SpawnBubble ();
		}
	}
}
