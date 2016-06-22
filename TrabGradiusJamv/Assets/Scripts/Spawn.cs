using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	float tempo;
	public GameObject inimigo;
	bool spawn;
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
			
		}
		if (spawn && NHorda == 1) {
			Instantiate(inimigo, enemyrespawn.transform.position, enemyrespawn.transform.localRotation);
			spawn = false;

		}

		if (tempo >= 130f) {
			
		}
	}
}
