using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballright : MonoBehaviour {

	public float vitesse;

	void Start () {

		vitesse = 10f;
	}
	

	void Update () {

		transform.Translate (Vector2.right * Time.deltaTime * vitesse);
	}


	void OnCollisionEnter2D(Collision2D col) {

		if (col.gameObject.name != "chicken") {
			Destroy (gameObject);
		}
	}
}
