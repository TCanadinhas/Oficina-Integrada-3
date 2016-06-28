using UnityEngine;
using System.Collections;

public class resetScore : MonoBehaviour {
	
	// Use this to initialize the score
	public void ResetScore(){
		PlayerPrefs.SetInt("score", 0);
	}
}
