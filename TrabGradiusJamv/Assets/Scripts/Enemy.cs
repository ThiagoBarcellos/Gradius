using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private bool movimentovertical= true;

	float speed = 2f;
	float speedfrente = -0.5f;


	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed);
		transform.Translate (Vector2.right *speedfrente );

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

	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(gameObject.tag == "rocket")
		{
			Destroy (this.gameObject);
		}
	}
}
