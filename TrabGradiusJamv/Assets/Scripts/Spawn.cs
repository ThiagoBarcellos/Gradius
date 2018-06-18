using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	float tempo;
	float tempo2;
	float tempoMeteoro;
	float tempobuff;

	int vaiSpawnar;

	public GameObject inimigo;
	public GameObject inimigo2;
	public GameObject meteoro;
	public GameObject Ampulheta;

	bool spawnInimigos;
	bool spawnInimigo2;
	bool spawnMeteoro;
	bool spawnbuff;

	[SerializeField]
	private GameObject enemyrespawn;

	public GameObject Ienemyrespawn;
	public GameObject Fenemyrespawn;

	void Start () {
		spawnInimigos = false;
		spawnInimigo2 = false;
		spawnMeteoro = false;
		spawnbuff = false;

		tempo = Time.deltaTime;
		tempoMeteoro = Time.deltaTime;
		tempo2 = Time.deltaTime;
		tempobuff = Time.deltaTime;
	}
	
	void Update () {
		tempo += Time.deltaTime;
		tempoMeteoro += Time.deltaTime;
		tempo2 += Time.deltaTime;
		tempobuff += Time.deltaTime;

		if (tempo >= 4 && spawnInimigos == false) {
			spawnInimigos = true;
			tempo = 0;
		}
		if (tempoMeteoro >= 1 && spawnMeteoro == false) {
			spawnMeteoro = true;
			tempoMeteoro = 0;
		}
		if (tempo2 >= 6 && spawnInimigo2 == false) {
			spawnInimigo2 = true;
			tempo2 = 0;
		}
		if (tempobuff >= 10 && spawnbuff == false) {
			vaiSpawnar = (int)Random.Range (0f, 10f);
			Debug.Log (vaiSpawnar);
			if (vaiSpawnar < 4) {
				tempobuff = 0f;
			}
			else {
				spawnbuff = true;
				tempobuff = 0;
			}
		}

		if (spawnInimigos) {
			Vector2 position = new Vector2 (Random.Range (Ienemyrespawn.transform.position.x, Fenemyrespawn.transform.position.x), enemyrespawn.transform.position.y);
			Instantiate(inimigo, position , enemyrespawn.transform.localRotation);
			spawnInimigos = false;
		}
		if (spawnMeteoro) {
			Vector2 position = new Vector2 (Random.Range (Ienemyrespawn.transform.position.x, Fenemyrespawn.transform.position.x), enemyrespawn.transform.position.y);
			Instantiate(meteoro, position , enemyrespawn.transform.localRotation);
			spawnMeteoro = false;
		}
		if (spawnInimigo2) {
			Vector2 position = new Vector2 (Random.Range (Ienemyrespawn.transform.position.x, Fenemyrespawn.transform.position.x), enemyrespawn.transform.position.y);
			Instantiate(inimigo2, position , enemyrespawn.transform.localRotation);
			spawnInimigo2 = false;
		}
		if (spawnbuff) {
			Vector2 position = new Vector2 (Random.Range (Ienemyrespawn.transform.position.x, Fenemyrespawn.transform.position.x), enemyrespawn.transform.position.y);
			Instantiate(Ampulheta, position , enemyrespawn.transform.localRotation);
			spawnbuff = false;
		}
	}
}
