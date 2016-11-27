using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {


	public GameObject block;

	ArrayList blocks;


	// Use this for initialization
	void Start () {
		blocks = new ArrayList ();
		for (int i = 0; i < 31; i++) {
			GameObject newBlock = Instantiate (block, transform.position, Quaternion.identity) as GameObject;
			blocks.Add (newBlock);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
