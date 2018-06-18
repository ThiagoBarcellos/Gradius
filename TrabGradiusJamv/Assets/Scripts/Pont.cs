using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pont : MonoBehaviour {

	public Text pont;
	public Text pontMax;

	void Start(){
		pont.GetComponent<Text> ().text = "Pontuação: " + SceneManager.Pontuacao.ToString ();
		pontMax.GetComponent<Text> ().text = "Pontuação máxima: " + SceneManager.PontuacaoMax.ToString();
	}
}
