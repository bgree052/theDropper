using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {

	GameObject Canvas;

	void Update() {
		if (Input.anyKey){

			Application.LoadLevel ("First Level");

			Canvas.GetComponent<DestroyOnLoad> ().SendMessage ("Pressed");
		}
	}

}