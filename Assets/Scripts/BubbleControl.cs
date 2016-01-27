using UnityEngine;
using System.Collections;

public class BubbleControl : MonoBehaviour {


	public int speed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector2(0, 1) * Time.deltaTime * speed);
	}
}
