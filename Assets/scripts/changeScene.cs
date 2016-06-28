using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {
	
	// Use this for take a random scene
	public void ChangeScene(){
		
		Application.LoadLevel(Random.Range(1, Application.levelCount));
	}
}