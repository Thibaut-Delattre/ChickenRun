using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public Sprite Sprite1;
	public Sprite Sprite2;

	void Start () {

		gameObject.GetComponent<Image> ().sprite = Sprite1;
	}
	

	void Update () {
		
	}

	public void OnPointerEnter () {

		gameObject.GetComponent<Image> ().sprite = Sprite2;
	}
		





}
