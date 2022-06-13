using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cameramainmenu : MonoBehaviour {

	public GameObject ParametreImage;
	public GameObject MusicOnBouton;
	public GameObject MusicOffBouton;
	public GameObject MusicSlide;
	public GameObject MusicAudio;
	public GameObject actualmusic;
	public GameObject acualgroup;
	public Text actualmusictext;
	public GameObject Pause;
	public GameObject UnPause;
	public GameObject RestartMusic;
	public GameObject Commande;
	public GameObject Records;
	public GameObject ReturnMainMenu;
	public GameObject MusicButton;
	public GameObject SoundButton;
	public GameObject RecordButton;
	public GameObject CommandesButton;
	public GameObject MainMenuImage;
	public Text RecordsTextParametre;

	public float hightpiece;
	public float hightmort;
	public float hightscore;
	public float hightemps;
	public float hightminute;
	public float hightseconde;
	public float hightmiliseconde;
	public int inthightminute;
	public int inthightseconde;
	public int inthightmiliseconde;

	public void OnclickJouer() {

		SceneManager.LoadScene ("Chargement");
	}

	void Start() {

		ParametreImage.SetActive (false);
		MusicOffBouton.SetActive (false);
		UnPause.SetActive (false);

		hightpiece = PlayerPrefs.GetFloat ("HighPiece");
		hightmort = PlayerPrefs.GetFloat ("HighMort");
		hightemps = PlayerPrefs.GetFloat ("HighTemps");
		hightscore = PlayerPrefs.GetFloat ("HighScore"); 
	}

	void Update() {

		Time.timeScale = 1f;

		RecordsTextParametre.text = "Nombre de piece : " + hightpiece + "\nNombre de mort : " + hightmort + "\nTemps : " + inthightminute + "m " + inthightseconde + "s " + inthightmiliseconde + "ms" + "\nScore : " + hightscore.ToString("0.00");
		RecordsTextParametre.lineSpacing = 2.2f;
		hightminute = hightemps / 60f;
		inthightminute = Mathf.FloorToInt(hightminute);	
		hightseconde = hightemps - (inthightminute * 60);
		inthightseconde = Mathf.FloorToInt (hightseconde);
		hightmiliseconde = (int)(hightemps * 10f) % 10;
	}


	public void ParametreOpen() {

		ParametreImage.SetActive (true);
		MainMenuImage.SetActive (false);
	}

	public void QuitterJeu() {

		Application.Quit ();
	}

	public void Music() {

		MusicOnBouton.SetActive(!MusicOnBouton.activeInHierarchy);
		MusicOffBouton.SetActive(!MusicOffBouton.activeInHierarchy);

		if (MusicOnBouton.activeInHierarchy == true) {
			MusicSlide.SetActive (true);
			MusicAudio.GetComponent<AudioSource> ().mute = false;
			actualmusic.SetActive (true);
			acualgroup.SetActive (true);
			Pause.SetActive (true);
			RestartMusic.SetActive (true);
		}
		if (MusicOffBouton.activeInHierarchy == true) {
			MusicSlide.SetActive (false);
			MusicAudio.GetComponent<AudioSource> ().mute = true;
			acualgroup.SetActive (false);
			actualmusic.SetActive (false);
			Pause.SetActive (false);
			UnPause.SetActive (false);
			RestartMusic.SetActive (false);
		}
	}

	public void Pausevoid() {

		UnPause.SetActive(!UnPause.activeInHierarchy);
		Pause.SetActive(!Pause.activeInHierarchy);

		if (UnPause.activeInHierarchy == true) {
			MusicAudio.GetComponent<AudioSource> ().loop = false;
			MusicAudio.GetComponent<AudioSource> ().Pause ();
		}
		if (Pause.activeInHierarchy == true) {
			MusicAudio.GetComponent<AudioSource> ().loop = true;
			MusicAudio.GetComponent<AudioSource> ().UnPause ();
		}

	}

	public void RestartMusicVoid() {
	
		MusicAudio.GetComponent<AudioSource> ().Play ();
		UnPause.SetActive (false);
		Pause.SetActive (true);
	}

	public void CommandeVoid () {

		Commande.SetActive(!Commande.activeInHierarchy);
	}

	public void RecordsVoid () {

		Records.SetActive(!Records.activeInHierarchy);
	}

	public void AreYouSureToLeave() {

		ParametreImage.SetActive (false);
		MainMenuImage.SetActive (true);
	}
}
