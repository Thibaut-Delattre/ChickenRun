using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sol8 : MonoBehaviour {

	public float vitesse;
	public float lockPos;

	public bool versladroite = false;
	public bool verslagauche = false;


	void Start () {

		vitesse = 4f;
		lockPos = 0f;


	}
	

	void Update () {

		transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);

		if (gameObject.transform.position.x < 64.5f) {
			versladroite = true;
			verslagauche = false;
		}
		if (gameObject.transform.position.x > 83.5f) {
			versladroite = false;
			verslagauche = true;
		}


		if (versladroite == true) {
			gameObject.transform.Translate (Vector2.right * Time.deltaTime * vitesse);
		}
		if (verslagauche == true) {
			gameObject.transform.Translate (Vector2.left * Time.deltaTime * vitesse);
		}

	}



}
