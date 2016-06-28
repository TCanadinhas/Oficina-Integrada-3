using UnityEngine;
using System.Collections;

public class gameManagement : MonoBehaviour {

	private float deadline;


	// Use this for initialization
	void Start () {
		deadline = 2;
		PlayerPrefs.SetFloat("deadline", deadline);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
