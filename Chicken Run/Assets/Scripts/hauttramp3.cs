using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hauttramp3 : MonoBehaviour {


	public float vitesse;

	public bool vershaut = false;
	public bool versbas = false;


	void Start () {

		vitesse = 2f;
	}


	void Update () {

		if (gameObject.transform.position.y < 5.8f) {
			versbas = false;
			vershaut = true;
		}
		if (gameObject.transform.position.y > 6.85f) {
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
