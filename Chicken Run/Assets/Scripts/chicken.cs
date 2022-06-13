using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chicken : MonoBehaviour {

	public float vitesse;
	public float vitessemurbougeant;
	public float jumpSpeed;
	public float jumpspeedtramp;
	public float lockPos;
	public float checkpoint;
	public float widthmana;
	public float heighmana;
	public float posxmana;
	public float piece;
	public float HighPiece;
	public float mort;
	public float Highmort;
	public float temps;
	public float minutes;
	public float secondes;
	public float milisecondes;
	public float Hightemps;
	public float Highminutes;
	public float Highsecondes;
	public float Highmilisecondes;
	public float score;
	public float HighScore;

	public int intminutes;
	public int intsecondes;
	public int Highintminutes;
	public int Highintsecondes;
	public int FPS { get; private set; }

	public bool touchesol;
	public bool touchelave;
	public bool touchepic;
	public bool versladroite;
	public bool verslagauche;
	public bool interupteuron;
	public bool blockbougeantvershaut = false;
	public bool blockbougeantversbas = false;
	public bool peutclicker;
	public bool	accesmort = true;
	public bool accesr;
	public bool touchefinish;
	public bool acceslaunch;

	public GameObject gameover;
	public GameObject interupteur1;
	public GameObject murbougeant;
	public GameObject blockbougeant;
	public GameObject fireballright;
	public GameObject fireballleft;
	public GameObject fondvieboss;
	public GameObject fondviebossdeux;
	public GameObject vieboss;
	public GameObject textvieboss;
	public GameObject bulldog;
	public GameObject win;
	public GameObject pdc2;
	public GameObject pdc3;
	public GameObject pdc4;
	public GameObject Manableue;
	public GameObject mana1;
	public GameObject mana2;
	public GameObject mana3;
	public GameObject mana4;
	public GameObject ButtonParametre;
	public GameObject ReturnMainMenuButton;
	public GameObject Part2;
	public GameObject GameobjectPieceText;
	public GameObject GameobjectMortText;
	public GameObject GameobjectTempsText;
	public GameObject GameobjectScoreText;
	public GameObject PieceTextFinG;
	public GameObject MortTextFinG;
	public GameObject TempsTextFinG;
	public GameObject ScoreTextFinG;
	public GameObject FPSgameoject;

	public Text RecordHighParametre;
	public Text PieceText;
	public Text MortText;
	public Text TempsText;
	public Text ScoreText;
	public Text PieceTextFin;
	public Text MortTextFin;
	public Text TempsTextFin;
	public Text ScoreTextFin;
	public Text FPStext;

	private Rigidbody2D rigidBody;

	public BoxCollider2D boxcol;

	public AudioSource FailDeath;
	public AudioSource FailRetry;
	public AudioSource Fly;
	public AudioSource Walk;
	public AudioSource Bounce;
	public AudioSource Teleport;
	public AudioSource Slide;
	public AudioSource Checkpoint;
	public AudioSource Burn;
	public AudioSource Blood;
	public AudioSource Fireball;
	public AudioSource Chickencry;
	public AudioSource Button;

	public Collider2D[] CollidersInBox;
	public Collider2D[] CollidersNoInBox;
	public GameObject[] GameobjectsInBox;

	static string[] stringsFrom00To99 = {
		"00", "01", "02", "03", "04", "05", "06", "07", "08", "09",
		"10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
		"20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
		"30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
		"40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
		"50", "51", "52", "53", "54", "55", "56", "57", "58", "59",
		"60", "61", "62", "63", "64", "65", "66", "67", "68", "69",
		"70", "71", "72", "73", "74", "75", "76", "77", "78", "79",
		"80", "81", "82", "83", "84", "85", "86", "87", "88", "89",
		"90", "91", "92", "93", "94", "95", "96", "97", "98", "99"
	};

	void Start () {

		HighPiece = PlayerPrefs.GetFloat ("HighPiece");
		Highmort = PlayerPrefs.GetFloat ("HighMort");
		Hightemps = PlayerPrefs.GetFloat ("HighTemps");
		HighScore = PlayerPrefs.GetFloat ("HighScore");

		ReturnMainMenuButton.SetActive (false);
		gameover.SetActive (false);
		vieboss.SetActive (false);
		textvieboss.SetActive (false);
		fondvieboss.SetActive (false);
		fondviebossdeux.SetActive (false);
		win.SetActive (false);
		pdc2.SetActive (false);
		pdc3.SetActive (false);
		pdc4.SetActive (false);
		checkpoint = 1f;
		vitesse = 6f;
		vitessemurbougeant = 1f;
		jumpSpeed = 8f;
		jumpspeedtramp = 15f;
		lockPos = 0f;

		Walk.loop = true;
		Walk.Play();
		Slide.loop = true;
		Slide.Play ();
		Chickencry.loop = true;
		Chickencry.Play ();
		Fly.loop = true;
		Fly.Play ();
		Burn.loop = true;
		Burn.Play ();
		Blood.loop = true;
		Blood.Play ();

		InvokeRepeating ("invokemanableue", 1f, 0.05f);
		Manableue.GetComponent<RectTransform> ().localPosition = new Vector2 (-675f, -490f);

		rigidBody = GetComponent<Rigidbody2D> ();	

		boxcol = GetComponent<BoxCollider2D> ();

		peutclicker = true;
	}

	void Update () {

		transform.rotation = Quaternion.Euler (lockPos, lockPos, lockPos);

		if (Input.GetKey (KeyCode.Q) && touchelave == false && touchepic == false) {
			verslagauche = true;
			versladroite = false;
			gameObject.transform.Translate (Vector2.left * Time.deltaTime * vitesse);
		}
		if (Input.GetKey (KeyCode.D) && touchelave == false && touchepic == false) {
			verslagauche = false;
			versladroite = true;
			gameObject.transform.Translate (Vector2.right * Time.deltaTime * vitesse);
		}

		if (!Input.GetKey (KeyCode.Q) && !Input.GetKey (KeyCode.D) && versladroite == true && touchesol && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S)) {
			gameObject.GetComponent<Animator> ().Play ("chickenidleright");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (!Input.GetKey (KeyCode.Q) && !Input.GetKey (KeyCode.D) && verslagauche == true && touchesol && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S)) {
			gameObject.GetComponent<Animator> ().Play ("chickenidleleft");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (touchesol == false && versladroite == true && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenjumpright");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.UnPause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (touchesol == false && verslagauche == true && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenjumpleft");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.UnPause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (Input.GetKey (KeyCode.Q) && touchesol == true && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S)) {
			gameObject.GetComponent<Animator> ().Play ("chickenwalkleft");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (Input.GetKey (KeyCode.D) && touchesol == true && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S)) {
			gameObject.GetComponent<Animator> ().Play ("chickenwalkright");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (Input.GetKey (KeyCode.Q) && touchesol == false && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenjumpleft");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.UnPause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (Input.GetKey (KeyCode.D) && touchesol == false && touchelave == false && touchepic == false && !Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenjumpright");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.UnPause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (!Input.GetKey (KeyCode.Q) && !Input.GetKey (KeyCode.D) && versladroite == true && touchelave == false && touchepic == false && Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenassisright");
			boxcol.size = new Vector2 (0.52f, 0.4f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (!Input.GetKey (KeyCode.Q) && !Input.GetKey (KeyCode.D) && verslagauche == true && touchelave == false && touchepic == false && Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenassisleft");
			boxcol.size = new Vector2 (0.52f, 0.4f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (touchelave == false && touchepic == false && versladroite == true && Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.D) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenassisright");
			boxcol.size = new Vector2 (0.52f, 0.4f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (touchelave == false && touchepic == false && verslagauche == true && Input.GetKey (KeyCode.S) && Input.GetKey (KeyCode.Q) && gameover.activeInHierarchy == false) {
			gameObject.GetComponent<Animator> ().Play ("chickenassisleft");
			boxcol.size = new Vector2 (0.52f, 0.4f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
	
		if (touchesol == true) {
			if (!Input.GetKey (KeyCode.Q) && !Input.GetKey (KeyCode.D) && !Input.GetKey (KeyCode.S) && touchelave == false && touchepic == false && touchefinish == false) {
				Chickencry.UnPause ();
			}
			if (Input.GetKey (KeyCode.S)) {
				Slide.Pause ();
				Chickencry.Pause ();
				if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.Q)) {
					Slide.UnPause ();
				}
			}
			if (Input.GetKeyUp (KeyCode.S)) {
				Slide.Pause ();
			}
			if (!Input.GetKey (KeyCode.S)) {
				if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.Q)) {
					Walk.UnPause ();
					Chickencry.Pause ();
				}
				if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.Q)) {
					Walk.Pause ();
				}
				if (Input.GetKey (KeyCode.S)) {
					Walk.Pause ();	
				}
			}
		}
		if (touchesol == false) {
			Walk.Pause ();
			Slide.Pause ();
			Chickencry.Pause ();
		}
		if (touchelave == true) {
			Walk.Pause ();
			Slide.Pause ();
			Chickencry.Pause ();
		}
		if (touchepic == true) {
			Walk.Pause ();
			Slide.Pause ();
			Chickencry.Pause ();
		}
		if (touchefinish == true) {
			Chickencry.Pause ();
		}

		if (touchelave == true && versladroite == true) {
			gameObject.GetComponent<Animator> ().Play ("chickenfireright");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.UnPause ();
			Blood.Pause ();
			Invoke ("willdead", 2f);
		}
		if (touchelave == true && verslagauche == true) {
			gameObject.GetComponent<Animator> ().Play ("chickenfireleft");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.UnPause ();
			Blood.Pause ();
			Invoke ("willdead", 2f);
		}
			

		if (touchepic == true && versladroite == true) {
			gameObject.GetComponent<Animator> ().Play ("chickenbloodright");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.UnPause ();
			Invoke ("willdead", 2f);
		}
		if (touchepic == true && verslagauche == true) {
			gameObject.GetComponent<Animator> ().Play ("chickenbloodleft");
			boxcol.size = new Vector2 (0.52f, 0.65f);
			Fly.Pause ();
			Burn.Pause ();
			Blood.UnPause ();
			Invoke ("willdead", 2f);
		}


		if (Input.GetKeyDown (KeyCode.R) && checkpoint == 1f) {
			gameObject.transform.position = new Vector3 (-19f, 5f, -1f);
			touchesol = false;
			touchepic = false;
			touchelave = false;
			gameover.SetActive (false);
			mana1.SetActive (true);
			mana2.SetActive (true);
			mana3.SetActive (true);
			mana4.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.R) && checkpoint == 2f) {
			gameObject.transform.position = new Vector3 (130f, 7.6f, -1f);
			touchesol = false;
			touchepic = false;
			touchelave = false;
			gameover.SetActive (false);
			mana1.SetActive (true);
			mana2.SetActive (true);
			mana3.SetActive (true);
			mana4.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.R) && checkpoint == 3f) {
			gameObject.transform.position = new Vector3 (210f, 96.2f, -1f);
			touchesol = false;
			touchepic = false;
			touchelave = false;
			gameover.SetActive (false);
			mana1.SetActive (true);
			mana2.SetActive (true);
			mana3.SetActive (true);
			mana4.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.R) && checkpoint == 4f) {
			gameObject.transform.position = new Vector3 (34f, 88.5f, -1f);
			touchesol = false;
			touchepic = false;
			touchelave = false;
			gameover.SetActive (false);
			textvieboss.SetActive (false);
			fondvieboss.SetActive (false);
			fondviebossdeux.SetActive (false);
			vieboss.SetActive (false);
			mana1.SetActive (true);
			mana2.SetActive (true);
			mana3.SetActive (true);
			mana4.SetActive (true);
		}
		if (checkpoint == 5f) {
			win.SetActive (true);
			gameObject.transform.position = new Vector3 (-300f, 300f, -1f);
			mana1.SetActive (false);
			mana2.SetActive (false);
			mana3.SetActive (false);
			mana4.SetActive (false);
			ButtonParametre.SetActive (false);
			ReturnMainMenuButton.SetActive (true);
			GameobjectPieceText.SetActive (false);
			GameobjectMortText.SetActive (false);
			GameobjectTempsText.SetActive (false);
			GameobjectScoreText.SetActive (false);
			PieceTextFinG.SetActive (true);
			MortTextFinG.SetActive (true);
			TempsTextFinG.SetActive (true);
			ScoreTextFinG.SetActive (true);
			if (Highmort == 0f && Hightemps == 0f) {
				Highmort = 1000f;
				Hightemps = 1000f;
			}
			PlayerPrefs.SetFloat ("HighPiece", HighPiece);
			if (piece >= HighPiece) {
				HighPiece = piece;
			}
			PlayerPrefs.SetFloat ("HighMort", Highmort);
			if (mort <= Highmort) {
				Highmort = mort;
			}
			PlayerPrefs.SetFloat ("HighTemps", Hightemps);
			if (temps <= Hightemps) {
				Hightemps = temps;
			}
			PlayerPrefs.SetFloat ("HighScore", HighScore);
			if (score >= HighScore) {
				HighScore = score;
			}

		}

		if (gameover.activeSelf == true && accesmort == true) {
			mort = mort + 1;
			gameObject.transform.position = new Vector3 (-300f, 300f, -1f);
			touchelave = false;
			touchepic = false;
			FailDeath.Play ();
			accesmort = false;
			acceslaunch = false;
			mana1.SetActive (false);
			mana2.SetActive (false);
			mana3.SetActive (false);
			mana4.SetActive (false);
		}
		if (gameover.activeSelf == false) {
			accesmort = true;
		}
		if (Input.GetKeyDown (KeyCode.R) && accesr == true) {
			mort = mort + 1;
			acceslaunch = false;
			FailRetry.Play ();
		}
		if (gameover.activeSelf == true) {
			accesr = false;
		}
		if (gameover.activeSelf == false) {
			accesr = true;
		}


		if (interupteuron == false) {
			interupteur1.GetComponent<Animator> ().Play ("interupteuranim");
			vitessemurbougeant = 0f;
			murbougeant.transform.localPosition = new Vector3 (141.6171f, 94.92504f, -2.949219f);
		}
		if (interupteuron == true) {
			interupteur1.GetComponent<Animator> ().Play ("interupteuranimferme");
			vitessemurbougeant = 1f;
			murbougeant.transform.Translate (Vector3.up * Time.deltaTime * vitessemurbougeant);
		}

		if (Input.GetKeyDown (KeyCode.Return) && versladroite == true && peutclicker == true && !Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			Instantiate (fireballright, transform.position, transform.rotation);
			Fireball.Play ();
			peutclicker = false;
			Invoke ("peutclickerinvoke", 1f);
			Manableue.GetComponent<RectTransform> ().sizeDelta = new Vector2 (0f, 50f);
			Manableue.GetComponent<RectTransform> ().localPosition = new Vector2 (-925f, -490f);
		}
		if (Input.GetKeyDown (KeyCode.Return) && verslagauche == true && peutclicker == true && !Input.GetKey (KeyCode.S) && gameover.activeInHierarchy == false) {
			Instantiate (fireballleft, transform.position, transform.rotation);
			Fireball.Play ();
			peutclicker = false;
			Invoke ("peutclickerinvoke", 1f);
			Manableue.GetComponent<RectTransform> ().sizeDelta = new Vector2 (0f, 50f);
			Manableue.GetComponent<RectTransform> ().localPosition = new Vector2 (-925f, -490f);
		}
			
		widthmana = Manableue.GetComponent<RectTransform> ().sizeDelta.x;
		heighmana = Manableue.GetComponent<RectTransform> ().sizeDelta.y;
		posxmana = Manableue.GetComponent<RectTransform> ().localPosition.x;

		if (gameover.activeInHierarchy == true) {

			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
		if (win.activeInHierarchy == true) {

			Fly.Pause ();
			Burn.Pause ();
			Blood.Pause ();
		}
			
		if (gameover.activeSelf == false && win.activeSelf == false) {
			temps += Time.deltaTime;
		}

		minutes = temps / 60f;
		intminutes = Mathf.FloorToInt (minutes);	
		secondes = temps - (intminutes * 60);
		intsecondes = Mathf.FloorToInt (secondes);
		milisecondes = (int)(temps * 10f) % 10;

		Highminutes = Hightemps / 60f;
		Highintminutes = Mathf.FloorToInt (Highminutes);	
		Highsecondes = Hightemps - (Highintminutes * 60);
		Highintsecondes = Mathf.FloorToInt (Highsecondes);
		Highmilisecondes = (int)(Hightemps * 10f) % 10;

		score = piece - mort - (temps / 10 / 2);

		RecordHighParametre.text = "Nombre de piece : " + HighPiece + "\nNombre de mort : " + Highmort + "\nTemps : " + Highintminutes + "m " + Highintsecondes + "s " + Highmilisecondes + "ms " + "\nScore : " + HighScore.ToString ("0.00");
		RecordHighParametre.lineSpacing = 2.2f;

		PieceText.text = "Nombre de piece : " + piece;
		MortText.text = "Nombre de mort : " + mort;
		TempsText.text = "Temps : " + intminutes + "m " + intsecondes + "s " + milisecondes + "ms ";
		ScoreText.text = "Score : " + score.ToString ("0.00");

		PieceTextFin.text = "Nombre de piece : " + piece + " | Record : " + HighPiece;
		MortTextFin.text = "Nombre de mort : " + mort + " | Record : " + Highmort;
		TempsTextFin.text = "Temps : " + intminutes + "m " + intsecondes + "s " + milisecondes + "ms " + " | Record : " + Highintminutes + "m " + Highintsecondes + "s " + Highmilisecondes + "ms ";
		ScoreTextFin.text = "Score : " + score.ToString ("0.00") + " | Record : " + HighScore.ToString ("0.00");
	
		FPS = (int)(1f / Time.unscaledDeltaTime);
		FPStext.text = "FPS : " + stringsFrom00To99[Mathf.Clamp(FPS, 0, 99)];

		if (blockbougeant.transform.position.y > 98f) {
			blockbougeantversbas = true;
			blockbougeantvershaut = false;
		}
		if (blockbougeant.transform.position.y < 86f) {
			blockbougeantvershaut = true;
			blockbougeantversbas = false;
		}

		if (blockbougeantversbas == true) {
			blockbougeant.transform.Translate (Vector2.down * Time.deltaTime * vitessemurbougeant);
		}
		if (blockbougeantvershaut == true) {
			blockbougeant.transform.Translate (Vector2.up * Time.deltaTime * vitessemurbougeant);
		}
	}

	public void invokemanableue() {
		
		if (Manableue.GetComponent<RectTransform> ().localPosition.x < -675f) {
			
			Manableue.GetComponent<RectTransform> ().localPosition = new Vector2 (posxmana + 12.5f, -490f);
			Manableue.GetComponent<RectTransform> ().sizeDelta = new Vector2 (widthmana + 25f, 50f);
		}
	}
		
	public void peutclickerinvoke() {

		peutclicker = true;
	}


	void FixedUpdate(){
	
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();

		if (touchesol == true && Input.GetKey (KeyCode.Space)) {
			rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);

		}
	}


	void OnCollisionStay2D(Collision2D col) {
	
		if (col.gameObject.tag == "sol") {
			touchesol = true;
		}
		if (col.gameObject.tag == "Finish") {
			touchefinish = true;
		}
			
	}

	void OnCollisionExit2D(Collision2D col) {

		if (col.gameObject.tag == "sol") {
			touchesol = false;
		}
		if (col.gameObject.tag == "Finish") {
			touchefinish = false;
		}
	}


	void OnCollisionEnter2D(Collision2D col){

		if (col.gameObject.tag == "hautdutramp") {
			rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpspeedtramp);
			Bounce.Play ();
		}

		if (col.gameObject.tag == "deadsol") {
			touchepic = true;
		}


		if (col.gameObject.tag == "lave") {
			touchelave = true;
		}
	}



	public void willdead() {

		if (touchepic == true) {
			gameover.SetActive (true);
		}
		if (touchelave == true) {
			gameover.SetActive (true);
		}
	}

	public void invokdepdc() {
		pdc2.SetActive (false);
		pdc3.SetActive (false);
		pdc4.SetActive (false);
	}

	public void invoketeleport1() {
		gameObject.transform.position = new Vector3 (210f, 96.2f, -1f);
	}
	public void invoketeleport2() {
		gameObject.transform.position = new Vector3 (183f, 24f, -1f);
		Part2.SetActive (false);
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.gameObject.name == "teleporteurportail") {
			Invoke ("invoketeleport1", 2f);
			Teleport.Play ();
			Part2.SetActive (true);
		}
		if (col.gameObject.name == "teleporteurportail2") {
			Invoke ("invoketeleport2", 2f);
			Teleport.Play ();
		}

		if (col.gameObject.name == "checkpointflag1") {
			checkpoint = 2f;
			pdc2.SetActive (true);
			Checkpoint.Play ();
			Invoke ("invokdepdc", 2f);
		}
		if (col.gameObject.name == "checkpointflag2") {
			checkpoint = 3f;
			pdc3.SetActive (true);
			Checkpoint.Play ();
			Invoke ("invokdepdc", 2f);
		}
		if (col.gameObject.name == "checkpointflag3") {
			checkpoint = 4f;
			pdc4.SetActive (true);
			Checkpoint.Play ();
			Invoke ("invokdepdc", 2f);
		}
		if (col.gameObject.name == "checkpointflag4") {
			checkpoint = 5f;
			Checkpoint.Play ();
		}

		if (col.gameObject.tag == "lave") {
			touchelave = true;
		}
		if (col.gameObject.tag == "deadsol") {
			touchepic = true; 
		}

		if (col.gameObject.name == "interupteur1") {
			interupteuron = true;
			Button.Play ();
		}
	

		if (col.gameObject.name == "detectboss") {
			acceslaunch = true;
			if (bulldog.activeInHierarchy == true) {
				fondvieboss.SetActive (true);
				fondviebossdeux.SetActive (true);
				vieboss.SetActive (true);
				textvieboss.SetActive (true);
			}
		}
	}

	public void PrintFPS() {
		
		FPSgameoject.SetActive(!FPSgameoject.activeInHierarchy);
	}

}
