using UnityEngine;
using System.Collections;

public class DeleteBlock : MonoBehaviour {

    GameObject ScoreManager;

    // Use this for initialization
    void Start () {
        ScoreManager = GameObject.Find("ScoreManager");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        Destroy(gameObject);

        ScoreManager.GetComponent<Score>().SendMessage("BlockRemoved");

    }
}
