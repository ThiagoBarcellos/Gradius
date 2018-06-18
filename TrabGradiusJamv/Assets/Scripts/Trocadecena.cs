using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Trocadecena : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.tag == "menu" && Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.Pontuacao = 0;
			MovimentoNave.Ntiros = 0;
			UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
		}
		if (gameObject.tag == "jogo" && Input.GetKeyDown(KeyCode.Space)) {
			MovimentoNave.Ntiros = 0;
			UnityEngine.SceneManagement.SceneManager.LoadScene("Jogo");
		}


		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit ();
		}
	}
}
