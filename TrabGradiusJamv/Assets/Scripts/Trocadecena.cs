using UnityEngine;
using System.Collections;

public class Trocadecena : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.tag == "creditos") {
			Application.LoadLevel("Creditos");
		}
		if (gameObject.tag == "menu") {
			Application.LoadLevel("Menu");
			Debug.Log ("volto");
		}
		if (gameObject.tag == "jogo" && Input.GetKeyDown(KeyCode.Space)) {
			Application.LoadLevel("Jogo");
			Debug.Log ("volto");
		}
	}
}
