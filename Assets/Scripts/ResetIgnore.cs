using UnityEngine;
using System.Collections;

public class ResetIgnore : MonoBehaviour {


	void Awake() {
		DontDestroyOnLoad(transform.gameObject);

		//if (gameObject == null) {
			//Instantiate (gameObject);
		
			//else{
				//!Instantiate(gameObject);
			//}
		//}
	}
}
