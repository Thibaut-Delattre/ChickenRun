using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class murmove : MonoBehaviour {

	public bool versdroite = false;
	public float posy;
	public float vitesse;


	void Start () {

		posy = transform.localPosition.y;
		vitesse = 4f;
	}
	

	void Update () {

		transform.Translate (Vector2.right * Time.deltaTime * vitesse);

		if (gameObject.transform.localPosition.x > 125f) {
			transform.localPosition = new Vector3 (38f, posy, -2f);
		}
	}
}
