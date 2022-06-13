using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicAudio : MonoBehaviour {

	public AudioSource audioSource;
	public AudioClip shoot1;
	public AudioClip shoot2;
	public AudioClip shoot3;
	public AudioClip shoot4;
	public AudioClip shoot5;
	public AudioClip shoot6;
	public AudioClip shoot7;
	public AudioClip shoot8;
	public AudioClip shoot9;
	public AudioClip shoot10;
	public AudioClip ActuelShoot;
	public int lenghtmax;
	public int lenghtmaxdeux;
	public int[] lenghtmaxssss;
	public int index;
	public GameObject Player;

	void Start()
	{
		audioSource = gameObject.GetComponent<AudioSource>();
		radommusic ();
	}
	void Update()
	{
		ActuelShoot = gameObject.GetComponent<AudioSource> ().clip;

		if (lenghtmax <= 10) {
			lenghtmaxdeux = lenghtmax;
		}

		if (audioSource.isPlaying == false && (Player.GetComponent<chicken> ().win.activeSelf == false || Player.GetComponent<chicken> ().gameover.activeSelf == false)) {
			if (lenghtmax == 10) {
				audioSource.clip = shoot1;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max10", 1f);
			}
			if (lenghtmax == 9) {
				audioSource.clip = shoot2;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max9", 1f);
			}
			if (lenghtmax == 8) {
				audioSource.clip = shoot3;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max8", 1f);
			}
			if (lenghtmax == 7) {
				audioSource.clip = shoot4;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max7", 1f);
			}
			if (lenghtmax == 6) {
				audioSource.clip = shoot5;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max6", 1f);
			}
			if (lenghtmax == 5) {
				audioSource.clip = shoot6;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max5", 1f);
			}
			if (lenghtmax == 4) {
				audioSource.clip = shoot7;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max4", 1f);
			}
			if (lenghtmax == 3) {
				audioSource.clip = shoot8;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max3", 1f);
			}
			if (lenghtmax == 2) {
				audioSource.clip = shoot9;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max2", 1f);
			}
			if (lenghtmax == 1) {
				audioSource.clip = shoot10;
				audioSource.Play ();
				audioSource.loop = true;
				audioSource.UnPause ();
				Invoke ("max1", 1f);
			}
		}
		if(Player.GetComponent<chicken>().win.activeSelf == true || Player.GetComponent<chicken>().gameover.activeSelf == true){
			audioSource.Pause();
		}
	}
	public void max10() {
		lenghtmax = 9;
	}
	public void max9() {
		lenghtmax = 8;
	}
	public void max8() {
		lenghtmax = 7;
	}
	public void max7() {
		lenghtmax = 6;
	}
	public void max6() {
		lenghtmax = 5;
	}
	public void max5() {
		lenghtmax = 4;
	}
	public void max4() {
		lenghtmax = 3;
	}
	public void max3() {
		lenghtmax = 2;
	}
	public void max2() {
		lenghtmax = 1;
	}
	public void max1() {
		lenghtmax = 10;
	}

	public void radommusic() {
		index = Random.Range (0, lenghtmaxssss.Length);
		lenghtmax = lenghtmaxssss [index];
	}

	public void invokdenext() {
		lenghtmax = lenghtmaxdeux - 1;
	}
	public void invokdenext2() {
		lenghtmax = 10;
	}

	public void invokeprevious() {
		lenghtmax = lenghtmaxdeux + 1;
	}
	public void invokeprevious2() {
		lenghtmax = 1;
	}

}
