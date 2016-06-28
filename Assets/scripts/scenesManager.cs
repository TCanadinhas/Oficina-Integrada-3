using UnityEngine;
using System.Collections;

public class scenesManager : MonoBehaviour {

	public float deadline;	// tempo para o minigame acabar
	public int currentLevel, nextLevel; // cena atual e a proxima cena

	// Use this for initialization
	void Start () {

		deadline = PlayerPrefs.GetFloat("deadline");
		currentLevel = Application.loadedLevel;
	}

	// Use this for take a random scene
	public void changeScene(){

		nextLevel = Random.Range(1, Application.levelCount);
		if(currentLevel == nextLevel)
			nextLevel = Random.Range(1, Application.levelCount);
		Application.LoadLevel(nextLevel); 
	}

	// Update is called once per frame
	void Update () {
		 
		deadline -= Time.deltaTime;
		Debug.Log (deadline);
		if (deadline <= 0)
				changeScene ();
	}
}