using UnityEngine;
using System.Collections;

public class CollisionSound : MonoBehaviour {

	//private AudioSource Audio;
	//public AudioClip Boop;


	void OnCollisionEnter2D (Collision2D collision){
		//Debug.Log ("Collision");

		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
		//other.relativeVelocity.magnitude / 20;
		//Debug.Log (other.relativeVelocity.magnitude);


		//Audio = GetComponent<AudioSource> ();
		//Audio.clip = Boop;
		//Audio.Play();

	}

	void Update(){
		//GetComponent<AudioSource>().Play();
	}
}