using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {


	public GameObject block;
    
    public GameObject block2;

	ArrayList blocks;

    ArrayList blocks2;

	// Use this for initialization
	void Start () {
		blocks = new ArrayList ();
		for (int i = 0; i < 31; i++) {
			GameObject newBlock = Instantiate (block, transform.position, Quaternion.identity) as GameObject;
			blocks.Add (newBlock);
		}
        blocks2 = new ArrayList();
        for (int i = 0; i < 6; i++) {
            GameObject newBlock = Instantiate(block2, transform.position, Quaternion.identity) as GameObject;
            blocks2.Add (newBlock);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
