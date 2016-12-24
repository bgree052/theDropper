using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    //static variables aren’t destroyed on scene changes and stay 
    //as long as the application is running.

    static int Deleted = 0;

    public Text timerScore;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timerScore.text = "Time: " + Mathf.Round(Time.time) + "        Blocks Removed: " + Deleted;
	
		if (Mathf.Round(Time.time) == 60) {
			Application.LoadLevel ("GAME OVER");
		}
	}

	public void BlockRemoved () {
		Deleted++;
		Debug.Log (Deleted);
	}

    

}
