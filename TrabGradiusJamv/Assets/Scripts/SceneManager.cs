using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

	static public int Pontuacao;
	static public int PontuacaoMax;
	static public float ContagemReg;

	public Text pontos;
	public Text Tempo;

	void Start () {
		ContagemReg = 60;
	}
	
	void FixedUpdate () {

		if (ContagemReg > 0f) {
			ContagemReg -= Time.fixedDeltaTime;
			Tempo.GetComponent<Text> ().text = ContagemReg.ToString ();
		}
		else {
			if (PontuacaoMax < Pontuacao) {
				PontuacaoMax = Pontuacao;
				MovimentoNave.Ntiros = 0;
				UnityEngine.SceneManagement.SceneManager.LoadScene (2);
			} 
			else {
				MovimentoNave.Ntiros = 0;
				UnityEngine.SceneManagement.SceneManager.LoadScene (2);
			}
		}
		Tempo.GetComponent<Text> ().text = ContagemReg.ToString();
		pontos.GetComponent<Text> ().text = "Pontos:" + Pontuacao.ToString();
	}
}
