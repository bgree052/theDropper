using UnityEngine;
using System.Collections;

public class Locations : MonoBehaviour {

	GameObject ScoreManager;

	// Use this for initialization
	void Start () {
		float xloc = Random.Range (-4f, 4f);
		float yloc = Random.Range (-43f, 2f);
		transform.position = new Vector3 (xloc, yloc, 0);
		ScoreManager = GameObject.Find ("ScoreManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

