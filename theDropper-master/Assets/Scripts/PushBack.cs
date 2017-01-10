using UnityEngine;
using System.Collections;

public class PushBack : MonoBehaviour {

	public float speed = 10;
	public Rigidbody2D rb;
	Vector3 pushRight;
	Vector3 pushLeft;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		//pushRight = new Vector3 (1f, 0f, 0f);
		//pushLeft = new Vector3 (-1f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
		void OnTriggerEnter (Collision2D other) {
		if (other.gameObject.tag == "Left Wall") {
			Debug.Log ("pushRight");
			rb.AddForce (Vector3.right * speed);
			}
		if (other.gameObject.tag == "Right Wall") {
			Debug.Log ("pushLeft");
			rb.AddForce (Vector3.left * speed);
		}
	}
}
