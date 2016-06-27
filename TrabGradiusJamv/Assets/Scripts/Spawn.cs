using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	float tempo;
	public GameObject inimigo;
	public GameObject boss;
	bool spawn;
	int Ninimigos = 0;
	[SerializeField]
	private GameObject enemyrespawn;
	int NHorda = 1;

	// Use this for initialization
	void Start () {
		spawn = false;
		tempo = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		tempo += Time.deltaTime;

		//Debug.Log (tempo);
		if (tempo >= 4 && spawn == false && NHorda == 1) {
			spawn = true;
			tempo = 0;
			Ninimigos++;
		}
		if (spawn && NHorda == 1) {
			Instantiate(inimigo, enemyrespawn.transform.position, enemyrespawn.transform.localRotation);
			spawn = false;

		}

		if (Ninimigos == 15) {
			NHorda = 2;
		}
		/*Debug.Log ("horda : " + NHorda);
		Debug.Log ("inimigos : " + Ninimigos);*/

		/*if (NHorda == 2) {
		Instantiate
		}*/
	}
}
