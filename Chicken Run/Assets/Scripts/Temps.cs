using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temps : MonoBehaviour {

	public Text piecetext;
	public Text morttext;
	public Text tempstext;
	public Text scoretext;
	public Text piecetextfint;
	public Text morttextfint;
	public Text scoretextfint;
	public Text tempstextfint;
	public Text RecordsTextParametre;

	public float temps;
	public float minutes;
	public int intminutes;
	public float secondes;
	public int intsecondes;
	public float milisecondes;
	public float score;
	public float hightscore;
	public float hightpiece;
	public float hightmort;
	public float hightminute;
	public float hightseconde;
	public float hightmiliseconde;
	public int inthightminute;
	public int inthightseconde;
	public int inthightmiliseconde;
	public float hightemps;

	public GameObject morttextfin;
	public GameObject piecetextfin;
	public GameObject tempstextfin;
	public GameObject scoretextfin;
	public GameObject morttextg;
	public GameObject piecetextg;
	public GameObject tempstextg;
	public GameObject scoretextg;
	public GameObject Chicken;

	void Start () {

		morttextfin.SetActive (false);
		piecetextfin.SetActive (false);
		tempstextfin.SetActive (false);
		scoretextfin.SetActive (false);

		hightpiece = PlayerPrefs.GetFloat ("currentpiece"); 
		hightmort = PlayerPrefs.GetFloat ("currentmort"); 
		hightscore = PlayerPrefs.GetFloat ("currentscore"); 
		hightemps = PlayerPrefs.GetFloat ("currentemps"); 
	}
	

	void Update () {

		if (Chicken.GetComponent<chicken>().gameover.activeSelf == false && Chicken.GetComponent<chicken>().win.activeSelf == false) {
			temps += Time.deltaTime;
		}

		RecordsTextParametre.text = "Nombre de piece : " + hightpiece + "\nNombre de mort : " + hightmort + "\nTemps : " + inthightminute + "m " + inthightseconde + "s " + inthightmiliseconde + "ms" + "\nScore : " + hightscore.ToString("0.00");
		RecordsTextParametre.lineSpacing = 2.2f;

		piecetext.text = "Nombre de piece : " + Chicken.GetComponent<chicken>().piece;
		morttext.text = "Nombre de mort : " + Chicken.GetComponent<chicken>().mort;
		tempstext.text = "Temps : " + temps;
		scoretext.text = "Score : " + score.ToString("0.00");

		piecetextfint.text = "Nombre de piece : " + Chicken.GetComponent<chicken>().piece + " | Record : " + hightpiece;
		morttextfint.text = "Nombre de mort : " + Chicken.GetComponent<chicken>().mort + " | Record : " + hightmort;
		tempstextfint.text = "Temps : " + intminutes + "m " + intsecondes + "s " + milisecondes + "ms "  + " | Record : " + inthightminute+ "m " + inthightseconde + "s " + inthightmiliseconde + "ms ";
		scoretextfint.text = "Score : " + score.ToString("0.00") + " | Record : " + hightscore.ToString("0.00");

		minutes = temps / 60f;
		intminutes = Mathf.FloorToInt(minutes);	
		secondes = temps - (intminutes * 60);
		intsecondes = Mathf.FloorToInt (secondes);
		milisecondes = (int)(temps * 10f) % 10;
		score = Chicken.GetComponent<chicken>().piece - Chicken.GetComponent<chicken>().mort - (temps / 10 / 2);

		hightminute = hightemps / 60f;
		inthightminute = Mathf.FloorToInt(hightminute);	
		hightseconde = hightemps - (inthightminute * 60);
		inthightseconde = Mathf.FloorToInt (hightseconde);
		hightmiliseconde = (int)(hightemps * 10f) % 10;

		if (Chicken.GetComponent<chicken> ().checkpoint == 5) {

			morttextg.SetActive (false);
			piecetextg.SetActive (false);
			tempstextg.SetActive (false);
			scoretextg.SetActive (false);
			morttextfin.SetActive (true);
			piecetextfin.SetActive (true);
			tempstextfin.SetActive (true);
			scoretextfin.SetActive (true);
			PlayerPrefs.SetFloat("currentpiece", hightpiece);
			if (Chicken.GetComponent<chicken>().piece >= hightpiece) {
				hightpiece = Chicken.GetComponent<chicken>().piece;
			}
			PlayerPrefs.SetFloat("currentmort", hightmort);
			if (Chicken.GetComponent<chicken>().mort <= hightmort) {
				hightmort = Chicken.GetComponent<chicken>().mort;
			}
			PlayerPrefs.SetFloat("currentscore", hightscore);
			if (score >= hightscore) {
				hightscore = score;
			}
			PlayerPrefs.SetFloat("currentemps", hightemps);
			if (temps <= hightemps) {
				hightemps = temps;
			}

		}

	}
}
