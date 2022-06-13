using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fondteleporteur : MonoBehaviour {

	public float vitesse;

	void Start () {

		vitesse = 100f;
		
	}
	

	void Update () {

		if (gameObject.name == "teleporteurfond") {
			transform.Rotate(Vector3.forward * Time.deltaTime * vitesse);
		}
		if (gameObject.name == "teleporteurfond2") {
			transform.Rotate(Vector3.back * Time.deltaTime * vitesse);
		}

	}
}
