using UnityEngine;
using System.Collections;

public class DestroyOnLoad : MonoBehaviour {

	public void Pressed() {
		Destroy(gameObject);
	}

}
