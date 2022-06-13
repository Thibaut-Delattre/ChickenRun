using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class camera : MonoBehaviour {

	public GameObject ParametreImage;
	public GameObject ParametreButton;
	public GameObject MusicOnBouton;
	public GameObject MusicOffBouton;
	public GameObject MusicSlide;
	public GameObject SoundOnBouton;
	public GameObject SoundOffBouton;
	public GameObject SoundSlide;
	public GameObject MusicAudio;
	public GameObject actualmusic;
	public GameObject acualgroup;
	public Text actualmusictext;
	public GameObject Pause;
	public GameObject UnPause;
	public GameObject Next;
	public GameObject Previous;
	public GameObject Commande;
	public GameObject Records;
	public GameObject ReturnMainMenu;
	public GameObject textAreYouSure;
	public GameObject AreYouSureNo;
	public GameObject AreYouSureYes;
	public GameObject MusicButton;
	public GameObject SoundButton;
	public GameObject AreYouSureImage;
	public GameObject RecordButton;
	public GameObject CommandesButton;

	public GameObject SoundSources1;
	public GameObject SoundSources2;
	public GameObject SoundSources3;
	public GameObject SoundSources4;
	public GameObject SoundSources5;
	public GameObject SoundSources6;
	public GameObject SoundSources7;
	public GameObject SoundSources8;
	public GameObject SoundSources9;
	public GameObject SoundSources10;
	public GameObject SoundSources11;
	public GameObject SoundSources12;
	public GameObject SoundSources13;
	public GameObject SoundSources14;
	public GameObject SoundSources15;
	public GameObject SoundSources16;
	public GameObject SoundSources17;

	void Start() {

		ParametreImage.SetActive (false);
		MusicOffBouton.SetActive (false);
		SoundOffBouton.SetActive (false);
		UnPause.SetActive (false);
		textAreYouSure.SetActive (false);
		AreYouSureNo.SetActive (false);
		AreYouSureYes.SetActive (false);
		AreYouSureImage.SetActive (false);
	}

	void Update() {

		actualmusictext.text = MusicAudio.GetComponent<MusicAudio> ().audioSource.clip.name;

		if(Input.GetKeyDown(KeyCode.Escape)){

			ParametreOpen();
		}
		if (ParametreImage.activeInHierarchy == true) {
			Time.timeScale = 0f;
		}
		if (ParametreImage.activeInHierarchy == false) {
			Time.timeScale = 1f;
		}
	}
		

	public void ParametreOpen() {

		ParametreImage.SetActive(!ParametreImage.activeInHierarchy);
	}

	public void Music() {

		MusicOnBouton.SetActive(!MusicOnBouton.activeInHierarchy);
		MusicOffBouton.SetActive(!MusicOffBouton.activeInHierarchy);

		if (MusicOnBouton.activeInHierarchy == true) {
			MusicSlide.SetActive (true);
			MusicAudio.GetComponent<MusicAudio> ().radommusic ();
			actualmusic.SetActive (true);
			acualgroup.SetActive (true);
			Next.SetActive (true);
			Previous.SetActive (true);
			Pause.SetActive (true);
		}
		if (MusicOffBouton.activeInHierarchy == true) {
			MusicSlide.SetActive (false);
			MusicAudio.GetComponent<MusicAudio> ().lenghtmax = 20;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.loop = false;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.Pause ();
			acualgroup.SetActive (false);
			actualmusic.SetActive (false);
			Next.SetActive (false);
			Previous.SetActive (false);
			Pause.SetActive (false);
			UnPause.SetActive (false);
		}
	}

	public void Pausevoid() {
		
		UnPause.SetActive(!UnPause.activeInHierarchy);
		Pause.SetActive(!Pause.activeInHierarchy);

		if (UnPause.activeInHierarchy == true) {
			MusicAudio.GetComponent<MusicAudio> ().lenghtmax = 20;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.loop = false;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.Pause ();
		}
		if (Pause.activeInHierarchy == true) {
			MusicAudio.GetComponent<MusicAudio> ().lenghtmax = MusicAudio.GetComponent<MusicAudio> ().lenghtmaxdeux;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.loop = true;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.UnPause ();
		}

	}

	public void Nextvoid() {

		if (MusicAudio.GetComponent<MusicAudio> ().lenghtmax > 1 && MusicAudio.GetComponent<MusicAudio> ().lenghtmax <= 10) {
			MusicAudio.GetComponent<MusicAudio> ().lenghtmax = 20;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.loop = false;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.Pause ();
			MusicAudio.GetComponent<MusicAudio> ().invokdenext ();
		}
		if (MusicAudio.GetComponent<MusicAudio> ().lenghtmax == 1) {
			MusicAudio.GetComponent<MusicAudio> ().lenghtmax = 20;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.loop = false;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.Pause ();
			MusicAudio.GetComponent<MusicAudio> ().invokdenext2 ();
		}
	}

	public void Previousvoid() {

		if (MusicAudio.GetComponent<MusicAudio> ().lenghtmax < 10 && MusicAudio.GetComponent<MusicAudio> ().lenghtmax >= 1) {
			MusicAudio.GetComponent<MusicAudio> ().lenghtmax = 20;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.loop = false;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.Pause ();
			MusicAudio.GetComponent<MusicAudio> ().invokeprevious ();
		}
		if (MusicAudio.GetComponent<MusicAudio> ().lenghtmax == 10) {
			MusicAudio.GetComponent<MusicAudio> ().lenghtmax = 20;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.loop = false;
			MusicAudio.GetComponent<MusicAudio> ().audioSource.Pause ();
			MusicAudio.GetComponent<MusicAudio> ().invokeprevious2 ();
		}
	}

	public void SoundVoid ()
	{

		SoundOnBouton.SetActive (!SoundOnBouton.activeInHierarchy);
		SoundOffBouton.SetActive (!SoundOffBouton.activeInHierarchy);

		if (SoundOffBouton.activeInHierarchy == true) {
			SoundSources1.GetComponent<AudioSource> ().mute = true;
			SoundSources2.GetComponent<AudioSource> ().mute = true;
			SoundSources3.GetComponent<AudioSource> ().mute = true;
			SoundSources4.GetComponent<AudioSource> ().mute = true;
			SoundSources5.GetComponent<AudioSource> ().mute = true;
			SoundSources6.GetComponent<AudioSource> ().mute = true;
			SoundSources7.GetComponent<AudioSource> ().mute = true;
			SoundSources8.GetComponent<AudioSource> ().mute = true;
			SoundSources9.GetComponent<AudioSource> ().mute = true;
			SoundSources10.GetComponent<AudioSource> ().mute = true;
			SoundSources11.GetComponent<AudioSource> ().mute = true;

			SoundSources12.GetComponent<AudioSource> ().loop = false;
			SoundSources13.GetComponent<AudioSource> ().loop = false;
			SoundSources14.GetComponent<AudioSource> ().loop = false;
			SoundSources15.GetComponent<AudioSource> ().loop = false;
			SoundSources16.GetComponent<AudioSource> ().loop = false;
			SoundSources17.GetComponent<AudioSource> ().loop = false;

			SoundSources12.GetComponent<AudioSource> ().mute = true;
			SoundSources13.GetComponent<AudioSource> ().mute = true;
			SoundSources14.GetComponent<AudioSource> ().mute = true;
			SoundSources15.GetComponent<AudioSource> ().mute = true;
			SoundSources16.GetComponent<AudioSource> ().mute = true;
			SoundSources17.GetComponent<AudioSource> ().mute = true;

			SoundSlide.SetActive (false);
		}

		if (SoundOnBouton.activeInHierarchy == true) {
			SoundSources1.GetComponent<AudioSource> ().mute = false;
			SoundSources2.GetComponent<AudioSource> ().mute = false;
			SoundSources3.GetComponent<AudioSource> ().mute = false;
			SoundSources4.GetComponent<AudioSource> ().mute = false;
			SoundSources5.GetComponent<AudioSource> ().mute = false;
			SoundSources6.GetComponent<AudioSource> ().mute = false;
			SoundSources7.GetComponent<AudioSource> ().mute = false;
			SoundSources8.GetComponent<AudioSource> ().mute = false;
			SoundSources9.GetComponent<AudioSource> ().mute = false;
			SoundSources10.GetComponent<AudioSource> ().mute = false;
			SoundSources11.GetComponent<AudioSource> ().mute = false;

			SoundSources12.GetComponent<AudioSource> ().loop = true;
			SoundSources13.GetComponent<AudioSource> ().loop = true;
			SoundSources14.GetComponent<AudioSource> ().loop = true;
			SoundSources15.GetComponent<AudioSource> ().loop = true;
			SoundSources16.GetComponent<AudioSource> ().loop = true;
			SoundSources17.GetComponent<AudioSource> ().loop = true;

			SoundSources12.GetComponent<AudioSource> ().mute = false;
			SoundSources13.GetComponent<AudioSource> ().mute = false;
			SoundSources14.GetComponent<AudioSource> ().mute = false;
			SoundSources15.GetComponent<AudioSource> ().mute = false;
			SoundSources16.GetComponent<AudioSource> ().mute = false;
			SoundSources17.GetComponent<AudioSource> ().mute = false;

			SoundSlide.SetActive (true);
		}
	}

	public void CommandeVoid () {

		Commande.SetActive(!Commande.activeInHierarchy);
	}

	public void RecordsVoid () {

		Records.SetActive(!Records.activeInHierarchy);
	}

	public void AreYouSureToLeave() {

		textAreYouSure.SetActive (true);
		AreYouSureNo.SetActive (true);
		AreYouSureYes.SetActive(true);
		AreYouSureImage.SetActive (true);
		ParametreButton.GetComponent<Button> ().interactable = false;
	}

	public void AreYouSureYesVoid() {

		SceneManager.LoadScene ("MainMenu");
	}

	public void AreYouSureNoVoid() {

		textAreYouSure.SetActive (false);
		AreYouSureNo.SetActive (false);
		AreYouSureYes.SetActive(false);
		AreYouSureImage.SetActive (false);
		ParametreButton.GetComponent<Button> ().interactable = true;
	}
} 	


