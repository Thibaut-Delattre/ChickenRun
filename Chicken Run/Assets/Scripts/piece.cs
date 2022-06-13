using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piece : MonoBehaviour {

	public GameObject player;
	public AudioSource coin;

	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.gameObject.name == "chicken") {
			player.GetComponent<chicken> ().piece = player.GetComponent<chicken> ().piece + 1;
			coin.Play ();
			Destroy (gameObject);
		}
	}
}

