using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hauttramp : MonoBehaviour {

	public float vitesse;

	public bool vershaut = false;
	public bool versbas = false;

	void Start () {

		vitesse = 2f;
	}
	

	void Update () {

		if (gameObject.transform.position.y < -4.13f) {
			versbas = false;
			vershaut = true;
		}
		if (gameObject.transform.position.y > -3.04f) {
			vershaut = false;
			versbas = true;
		}



		if (vershaut == true) {
			gameObject.transform.Translate (Vector2.up * Time.deltaTime * vitesse);
		}
		if (versbas == true) {
			gameObject.transform.Translate (Vector2.down * Time.deltaTime * vitesse); 
		}

	}
}
