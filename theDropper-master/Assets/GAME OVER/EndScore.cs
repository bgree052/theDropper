using UnityEngine;
using System.Collections;

public class EndScore : MonoBehaviour {

	public GameObject KEPT;

	public DataHolder Data;

	int Score;

	void Start(){


		Data = KEPT.GetComponent<DataHolder> ();

		//Score = Data.LevelCleared;


	}
		
}
