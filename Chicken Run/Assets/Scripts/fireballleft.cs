using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballleft : MonoBehaviour {

	public float vitesse;

	void Start () {

		vitesse = 10f;
	}
	

	void Update () {

		transform.Translate (Vector2.left * Time.deltaTime * vitesse);
	}



	void OnCollisionEnter2D(Collision2D col) {

		if (col.gameObject.name != "chicken") {
			Destroy (gameObject);
		}
	}
}
