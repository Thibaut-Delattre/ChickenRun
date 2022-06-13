using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChargementScript : MonoBehaviour {

	public float SpeedRotate;

	void Start () {
	
		SpeedRotate = -5f;
		Invoke ("invokeChargerNiv1", 3f);

	}
	

	void Update () {

		gameObject.transform.Rotate (new Vector3 (0, 0, 20) * Time.deltaTime * SpeedRotate);
	}

	public void invokeChargerNiv1() {

		SceneManager.LoadScene ("Niv1");
	}
}
