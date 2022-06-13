using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockinv : MonoBehaviour {

	public GameObject blockinv1;
	public GameObject blockinv2;
	public GameObject blockinv3;
	public GameObject blockinv4;
	public GameObject blockinv5;
	public GameObject blockinv6;
	public GameObject blockinv7;
	public GameObject blockinv8;
	public GameObject blockinv9;
	public GameObject blockinv10;
	public GameObject blockinv11;


	void Start () {

		InvokeRepeating ("blockinvun", 2f, 8f);
		InvokeRepeating ("blockinvunw", 6f, 8f);

		InvokeRepeating ("blockinvdeux", 4f, 8f);
		InvokeRepeating ("blockinvdeuxw", 8f, 8f);

		InvokeRepeating ("blockinvtrois", 6f, 8f);
		InvokeRepeating ("blockinvtroisw", 2f, 8f);

		InvokeRepeating ("blockinvquatre", 8f, 8f);
		InvokeRepeating ("blockinvquatrew", 4f, 8f);

		InvokeRepeating ("blockinvcinq", 2f, 8f);
		InvokeRepeating ("blockinvcinqw", 6f, 8f);

		InvokeRepeating ("blockinvsix", 4f, 8f);
		InvokeRepeating ("blockinvsixw", 8f, 8f);

		InvokeRepeating ("blockinvsept", 6f, 8f);
		InvokeRepeating ("blockinvseptw", 2f, 8f);

		InvokeRepeating ("blockinvhuit", 8f, 8f);
		InvokeRepeating ("blockinvhuitw", 4f, 8f);

		InvokeRepeating ("blockinvneuf", 2f, 8f);
		InvokeRepeating ("blockinvneufw", 6f, 8f);

		InvokeRepeating ("blockinvdix", 4f, 8f);
		InvokeRepeating ("blockinvdixw", 8f, 8f);

		InvokeRepeating ("blockinvonze", 6f, 8f);
		InvokeRepeating ("blockinvonzew", 2f, 8f);




	}
	

	void Update () {


	}


	public void blockinvun () {
		blockinv1.SetActive (false);
	}
	public void blockinvunw () {
		blockinv1.SetActive (true);
	}


	public void blockinvdeux () {
		blockinv2.SetActive (false);
	}
	public void blockinvdeuxw () {
		blockinv2.SetActive (true);
	}


	public void blockinvtrois () {
		blockinv3.SetActive (false);
	}
	public void blockinvtroisw () {
		blockinv3.SetActive (true);
	}


	public void blockinvquatre () {
		blockinv4.SetActive (false);
	}
	public void blockinvquatrew () {
		blockinv4.SetActive (true);
	}


	public void blockinvcinq () {
		blockinv5.SetActive (false);
	}
	public void blockinvcinqw () {
		blockinv5.SetActive (true);
	}


	public void blockinvsix () {
		blockinv6.SetActive (false);
	}
	public void blockinvsixw () {
		blockinv6.SetActive (true);
	}


	public void blockinvsept () {
		blockinv7.SetActive (false);
	}
	public void blockinvseptw () {
		blockinv7.SetActive (true);
	}


	public void blockinvhuit () {
		blockinv8.SetActive (false);
	}
	public void blockinvhuitw () {
		blockinv8.SetActive (true);
	}


	public void blockinvneuf () {
		blockinv9.SetActive (false);
	}
	public void blockinvneufw () {
		blockinv9.SetActive (true);
	}


	public void blockinvdix () {
		blockinv10.SetActive (false);
	}
	public void blockinvdixw () {
		blockinv10.SetActive (true);
	}


	public void blockinvonze () {
		blockinv11.SetActive (false);
	}
	public void blockinvonzew () {
		blockinv11.SetActive (true);
	}





}
