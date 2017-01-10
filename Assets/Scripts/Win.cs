using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {

    //GameObject KEPT;

    GameObject DATA; 

    // Use this for initialization
    void Start () {

        //KEPT = GameObject.Find("KEPT");

        DATA = transform.Find("DATA").gameObject;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		//Debug.Log ("Hit");

		if (other.gameObject.CompareTag ("End")) {

            DATA.GetComponent<theDataHolder>().SendMessage("LevelCleared");

            SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex);


        }
	}

    void MoveDown() {

        gameObject.transform.position = new Vector3(-0.8f, -41.7f, 0f);

    }

}
