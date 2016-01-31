using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public UnityEngine.UI.Text scoreText;

	public int score;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addScore(int addScore) {
		score += addScore;
		scoreText.text = "Score: " + score;
	}

}
