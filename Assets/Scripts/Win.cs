using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Hit");

		if (other.gameObject.CompareTag ("End")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
