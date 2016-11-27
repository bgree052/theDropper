using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	int Deleted = 0;

	public Text timerScore;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timerScore.text = "Time: " + Mathf.Round(Time.time) + "        Blocks Removed: " + Deleted;
	}

	public void BlockRemoved () {
		Debug.Log ("DETECTED");
		Deleted++;
		Debug.Log (Deleted);
	}
}
