using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulepic : MonoBehaviour {

	public float vitesserot;
	public float vitesse;



	void Start () {

		vitesserot = 200f;
		vitesse = 10f;
	}
	

	void Update () {

		gameObject.transform.Rotate (Vector3.back * Time.deltaTime * vitesserot);
		gameObject.transform.parent.Translate (Vector2.right * Time.deltaTime * vitesse);

	}


	void OnTriggerEnter2D(Collider2D col){
	
		if (col.gameObject.tag == "Finish") {
			Destroy (gameObject);
		}


	}

}
