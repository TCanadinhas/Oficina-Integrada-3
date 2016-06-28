using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class main : MonoBehaviour {

	private int score, highScore; // score atual e hightscore
	public Text hud;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("score");
		highScore = PlayerPrefs.GetInt("highScore");
	}
	
	// Update is called once per frame
	void Update () {
		score++;
		PlayerPrefs.SetInt("score", score);
		Debug.Log(score);
		hud.text = "Score: " + score + "  ||  Highscore: " + highScore;
		if(Input.GetKeyDown(KeyCode.Escape)){
			PlayerPrefs.SetInt("score",0);
			if(highScore > score)
				PlayerPrefs.SetInt("highScore", score);
			Application.Quit();
		}
	}
}
