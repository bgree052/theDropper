using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MovePlayerBottom : MonoBehaviour {

	GameObject Canvas;

	GameObject player;

	void Start() {
	
		player = GameObject.Find ("Player");

	
	}

	void Update() {
		if (Input.anyKey){




			Debug.Log ("BUTTON PRESSED");
		}
	}

}
