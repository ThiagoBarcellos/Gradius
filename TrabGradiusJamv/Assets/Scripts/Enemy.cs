using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private bool movimentovertical= true;

	float speed = 2f;
	float speedfrente = -1f;
	float recarga = 0;
	public GameObject tiro;

	public GameObject tirospawn;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed);
		transform.Translate (Vector2.right *speedfrente );
		recarga ++;
		//Debug.Log (recarga);
		if(transform.position.y > 230f)
		{
			speed = -2f;
		}
		if(transform.position.y < 26f)
		{
			speed = 2f;
		}

		if(transform.position.x < -40f)
		{
			Destroy (this.gameObject);
		}
		if (recarga == 50) {
			Instantiate(tiro, tirospawn.transform.position, tiro.transform.localRotation);
			recarga =0;
		}

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(gameObject.tag == "rocket" || gameObject.tag == "player")
		{
			Destroy (this.gameObject);
		}
	}
}
