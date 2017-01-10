using UnityEngine;
using System.Collections;

public class EndScore : MonoBehaviour {

	public GameObject KEPT;

	public theDataHolder Data;

	int Score;

	void Start(){


		Data = KEPT.GetComponent<theDataHolder> ();

        //Score = Data.LevelCleared;

        Debug.Log(Data);
	}
		
}
