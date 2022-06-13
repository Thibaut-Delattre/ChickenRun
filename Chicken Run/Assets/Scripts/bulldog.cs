using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulldog : MonoBehaviour {

	public GameObject boulepic;
	public GameObject barredevieboss;
	public GameObject player;

	public float rotz;
	public float viebulldog;

	public AudioSource Hit;
	public AudioSource Launchdog;
	public AudioSource Explosion;

	void Start ()  {

		viebulldog = 100f;
		InvokeRepeating ("lanceboulepic", 1f, 1f);
	}
	

	void Update () {

		if (viebulldog > 0f) {
			gameObject.GetComponent<Animator> ().Play ("bulldoganimation");
		}
		if (viebulldog <= 0f) {
			Explosion.Play ();
			gameObject.transform.localScale = new Vector3 (5f, 5f, 1f);
			gameObject.transform.localPosition = new Vector3 (-78.4f, 92.66f, -9.03125f);
			gameObject.GetComponent<Animator> ().Play ("bulldogexplosionanim");
			player.GetComponent<chicken>().textvieboss.SetActive (false);
			player.GetComponent<chicken>().fondvieboss.SetActive (false);
			player.GetComponent<chicken>().fondviebossdeux.SetActive (false);
			player.GetComponent<chicken>().vieboss.SetActive (false);
			Destroy (gameObject, 3.02f);

		}
	}

	public void lanceboulepic() {
		if (player.GetComponent<chicken> ().acceslaunch == true) {
			Instantiate (boulepic, new Vector3 (-75f, 90f, -15f), Quaternion.Euler (new Vector3 (0f, 0f, Random.Range (-20f, 20f))));
			Launchdog.Play ();
		}
	}


	void OnCollisionEnter2D(Collision2D col){
		 
		if (col.gameObject.tag == "fireball") {
			viebulldog = viebulldog - 5f;
			Hit.Play ();
			barredevieboss.transform.localScale -= new Vector3 (0.05f, 0f, 0f);
		}
	}
}
