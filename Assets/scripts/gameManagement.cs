using UnityEngine;
using System.Collections;

public class gameManagement : MonoBehaviour {

	private float deadline; // tempo para o minigame acabar
	private int highScore;

	void Management(){
		deadline = 2;
		PlayerPrefs.SetFloat("deadline", deadline);
		highScore = PlayerPrefs.GetInt("highScore");
	}
}
