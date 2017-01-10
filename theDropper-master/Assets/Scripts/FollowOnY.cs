using UnityEngine;
using System.Collections;

public class FollowOnY : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//had to look up help for this bit of code
		transform.position = new Vector3 (transform.position.x, player.position.y-3, -15);

	}
}
