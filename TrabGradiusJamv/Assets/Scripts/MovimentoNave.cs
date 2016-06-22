using UnityEngine;
using System.Collections;

public class MovimentoNave : MonoBehaviour {
	//public bool shoot = false;
	//GameObject nave = new GameObject("nave");
	// Use this for initialization
	public static int Ntiros = 0;
	public GameObject missil;

	[SerializeField]
	private GameObject spawnPoint;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= 245) {
			if (Input.GetKey (KeyCode.W)) {
				transform.Translate (Vector2.up *2 /* Time.deltaTime * 5*/);
			}
		}
		if (transform.position.x <= 546) {
			if (Input.GetKey (KeyCode.D)) {
				transform.Translate (Vector2.right *2 /* Time.deltaTime * 5*/);
			}
		}
		if (transform.position.y >= 21) {
			if (Input.GetKey (KeyCode.S)) {
				transform.Translate (Vector2.up /* Time.deltaTime */* -3);
			}
		}
		if (transform.position.x >= 33) {
			if (Input.GetKey (KeyCode.A)) {
				transform.Translate (Vector2.right /* Time.deltaTime */ * -3);
			}
		} 	
		if (Ntiros < 5 && Input.GetKeyDown (KeyCode.Space)) {
			//Debug.Log(Ntiros);
			Instantiate(missil, spawnPoint.transform.position, missil.transform.localRotation);
			Ntiros ++;
		}

	}

	/*void OnCollisionEnter2D(Collision2D coll)
	{
		Destroy (this.gameObject);
	}*/

}
