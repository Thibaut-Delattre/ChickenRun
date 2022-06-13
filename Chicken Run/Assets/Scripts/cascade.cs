using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cascade : MonoBehaviour {

	public float vitesse;

	void Start () {

		vitesse = 4f;
	}
	

	void Update () {

		gameObject.transform.Translate (Vector2.down * Time.deltaTime * vitesse);

		if (gameObject.transform.position.y < 61f) {
			transform.position = new Vector3 (161.37f, 125f, -9.2f);
		}
	}
}
