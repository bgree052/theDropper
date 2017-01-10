using UnityEngine;
using System.Collections;

public class DeleteBlock : MonoBehaviour {

    GameObject ScoreManager;
	public AudioClip click;



    // Use this for initialization
    void Start () {
        ScoreManager = GameObject.Find("ScoreManager");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {

		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().PlayOneShot(click, 1f);

        Destroy(gameObject);



        ScoreManager.GetComponent<Score>().SendMessage("BlockRemoved");

    }
}
