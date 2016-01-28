using UnityEngine;
using System.Collections;

public class CanonControl : MonoBehaviour {

	public GameObject bubblePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnBubble() {
		Instantiate (bubblePrefab, transform.position + new Vector3(0,1,0), Quaternion.identity);
	}

}
